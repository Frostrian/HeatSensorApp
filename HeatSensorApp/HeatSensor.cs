using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace HeatSensorApp
{
    public partial class HeatSensor : Form
    {
        public HeatSensor()
        {
            InitializeComponent();
        }

        private SensorCore sensor;

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var config = new SensorConfig
            {
                DeviceId = txtDeviceId.Text,
                WifiSSID = txtSSID.Text,
                WifiPassword = txtWifiPass.Text,
                MqttHost = txtMqttHost.Text,
                MqttPort = int.Parse(txtMqttPort.Text),
                MqttUsername = txtMqttUser.Text,
                MqttPassword = txtMqttPass.Text,
                StaticIp = txtStaticIp.Text
            };

            sensor = new SensorCore(config, Log);
            await sensor.StartAsync();
        }

        private void Log(string message)
        {
            txtLog.Invoke((MethodInvoker)(() =>
            {
                txtLog.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\n");
                txtLog.ScrollToCaret();
            }));
        }
    }
}
