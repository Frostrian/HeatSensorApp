using HeatSensorApp;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;
using System.Text;
using System.Timers;

public class SensorCore
{
    private IMqttClient mqttClient;
    private MqttFactory mqttFactory;
    private SensorConfig config;
    private Action<string> logAction;
    private System.Timers.Timer timerHeat, timerPing, timerBattery;
    private bool authenticated = false;

    public SensorCore(SensorConfig cfg, Action<string> logCallback)
    {
        config = cfg;
        logAction = logCallback;
        mqttFactory = new MqttFactory();
    }

    public async Task StartAsync()
    {
        mqttClient = mqttFactory.CreateMqttClient();

        var options = new MqttClientOptionsBuilder()
            .WithTcpServer(config.MqttHost, config.MqttPort)
            .WithClientId(config.DeviceId)
            .Build();

        mqttClient.ApplicationMessageReceivedAsync += async e =>
        {
            var topic = e.ApplicationMessage.Topic;
            var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);

            if (topic == $"auth/{config.DeviceId}/response")
            {
                HandleAuthResponse(payload);
            }

            await Task.CompletedTask;
        };

        await mqttClient.ConnectAsync(options, CancellationToken.None);
        logAction("MQTT bağlantısı kuruldu.");

        // Auth/response dinle
        await mqttClient.SubscribeAsync($"auth/{config.DeviceId}/response");

        // Auth/request gönder
        var authPayload = new
        {
            deviceId = config.DeviceId,
            ip = config.StaticIp,
            username = config.MqttUsername,
            password = config.MqttPassword
        };
        var json = System.Text.Json.JsonSerializer.Serialize(authPayload);

        var authMessage = new MqttApplicationMessageBuilder()
            .WithTopic("auth/request")
            .WithPayload(json)
            .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
            .Build();

        await mqttClient.PublishAsync(authMessage);
        logAction("Giriş isteği gönderildi.");
    }

    private void HandleAuthResponse(string payload)
    {
        var result = System.Text.Json.JsonSerializer.Deserialize<AuthResponse>(payload);

        if (result.status == "ok")
        {
            logAction("Doğrulama başarılı. Sensör aktif.");
            authenticated = true;
            StartDataTimers();
        }
        else
        {
            logAction("⚠ Doğrulama başarısız: " + result.reason);
        }
    }

    private void StartDataTimers()
    {

        timerPing = new System.Timers.Timer(25000);
        timerPing.Elapsed += async (s, e) =>
        {
            logAction("📡 Ping Timer Tick!");
            await SendPing();
        };
        timerPing.AutoReset = true;
        timerPing.Start();

        timerHeat = new System.Timers.Timer(50000);
        timerHeat.Elapsed += async (s, e) =>
        {
            logAction("🔥 Heat Timer Tick!");
            await SendHeat();
        };
        timerHeat.AutoReset = true;
        timerHeat.Start();


        timerBattery = new System.Timers.Timer(100000);
        timerBattery.Elapsed += async (s, e) =>
        {
            logAction("🔋 Battery Timer Tick!");
            await SendBattery();
        };
        timerBattery.AutoReset = true;
        timerBattery.Start();
    }

    private async Task SendHeat()
    {
        if (!authenticated || !mqttClient.IsConnected) return;

        try
        {
            double temp = new Random().Next(200, 350) / 10.0;
            var msg = $"{{\"deviceId\":\"{config.DeviceId}\",\"temperature\":{temp},\"timestamp\":\"{DateTime.Now:O}\"}}";

            var message = new MqttApplicationMessageBuilder()
                .WithTopic($"sensor/{config.DeviceId}/heat")
                .WithPayload(msg)
                .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                .Build();

            await mqttClient.PublishAsync(message);
            logAction("🌡 Isı bilgisi gönderildi.");
        }
        catch (Exception ex)
        {
            logAction("❌ Isı gönderme hatası: " + ex.Message);
        }
    }

    private async Task SendPing()
    {
        if (!authenticated || !mqttClient.IsConnected) return;

        try
        {
            var msg = $"{{\"deviceId\":\"{config.DeviceId}\",\"type\":\"ping\",\"timestamp\":\"{DateTime.Now:O}\"}}";

            var message = new MqttApplicationMessageBuilder()
                .WithTopic($"sensor/{config.DeviceId}/ping")
                .WithPayload(msg)
                .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                .Build();

            await mqttClient.PublishAsync(message);
            logAction("📶 Ping gönderildi.");
        }
        catch (Exception ex)
        {

            logAction("❌ ping gönderme hatası: " + ex.Message);
        }
    }

    private async Task SendBattery()
    {
        if (!authenticated || !mqttClient.IsConnected) return;
        try
        {

            int battery = new Random().Next(70, 100); // sabit tutabiliriz sonra azaltmalı yaparız

            var msg = $"{{\"deviceId\":\"{config.DeviceId}\",\"battery\":{battery},\"timestamp\":\"{DateTime.Now:O}\"}}";

            var message = new MqttApplicationMessageBuilder()
                .WithTopic($"sensor/{config.DeviceId}/battery")
                .WithPayload(msg)
                .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                .Build();

            await mqttClient.PublishAsync(message);
            logAction("🔋 Pil bilgisi gönderildi.");
        }
        catch (Exception ex)
        {
            logAction("❌ Pil gönderme hatası: " + ex.Message);
        }
    }

    private class AuthResponse
    {
        public string status { get; set; }
        public string reason { get; set; }
    }
}