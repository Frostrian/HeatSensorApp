namespace HeatSensorApp
{
    partial class HeatSensor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDeviceId = new TextBox();
            txtSSID = new TextBox();
            txtWifiPass = new TextBox();
            txtMqttHost = new TextBox();
            txtMqttPort = new TextBox();
            txtMqttPass = new TextBox();
            txtMqttUser = new TextBox();
            txtStaticIp = new TextBox();
            txtLog = new RichTextBox();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new Point(89, 10);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.Size = new Size(100, 23);
            txtDeviceId.TabIndex = 0;
            txtDeviceId.Text = "SENSOR_001";
            // 
            // txtSSID
            // 
            txtSSID.Location = new Point(89, 39);
            txtSSID.Name = "txtSSID";
            txtSSID.Size = new Size(100, 23);
            txtSSID.TabIndex = 0;
            txtSSID.Text = "OfficeWiFi";
            // 
            // txtWifiPass
            // 
            txtWifiPass.Location = new Point(89, 68);
            txtWifiPass.Name = "txtWifiPass";
            txtWifiPass.Size = new Size(100, 23);
            txtWifiPass.TabIndex = 0;
            txtWifiPass.Text = "12345678";
            // 
            // txtMqttHost
            // 
            txtMqttHost.Location = new Point(89, 97);
            txtMqttHost.Name = "txtMqttHost";
            txtMqttHost.Size = new Size(100, 23);
            txtMqttHost.TabIndex = 0;
            txtMqttHost.Text = "localhost";
            // 
            // txtMqttPort
            // 
            txtMqttPort.Location = new Point(89, 126);
            txtMqttPort.Name = "txtMqttPort";
            txtMqttPort.Size = new Size(100, 23);
            txtMqttPort.TabIndex = 0;
            txtMqttPort.Text = "1883";
            // 
            // txtMqttPass
            // 
            txtMqttPass.Location = new Point(89, 184);
            txtMqttPass.Name = "txtMqttPass";
            txtMqttPass.Size = new Size(100, 23);
            txtMqttPass.TabIndex = 0;
            txtMqttPass.Text = "sensorpass";
            // 
            // txtMqttUser
            // 
            txtMqttUser.Location = new Point(89, 155);
            txtMqttUser.Name = "txtMqttUser";
            txtMqttUser.Size = new Size(100, 23);
            txtMqttUser.TabIndex = 0;
            txtMqttUser.Text = "sensoruser";
            // 
            // txtStaticIp
            // 
            txtStaticIp.Location = new Point(89, 213);
            txtStaticIp.Name = "txtStaticIp";
            txtStaticIp.Size = new Size(100, 23);
            txtStaticIp.TabIndex = 0;
            txtStaticIp.Text = "192.168.1.11";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(222, 39);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(296, 197);
            txtLog.TabIndex = 1;
            txtLog.Text = "";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(222, 10);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(296, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "deviceId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 42);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Wifi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 71);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Pass";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 100);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "mqttHost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 129);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 3;
            label5.Text = "mqttPort";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 158);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 3;
            label6.Text = "mqttUser";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 187);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 3;
            label7.Text = "mqttPass";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 216);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 3;
            label8.Text = "staticIp";
            // 
            // HeatSensor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 256);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(txtLog);
            Controls.Add(txtStaticIp);
            Controls.Add(txtMqttHost);
            Controls.Add(txtMqttUser);
            Controls.Add(txtSSID);
            Controls.Add(txtMqttPass);
            Controls.Add(txtWifiPass);
            Controls.Add(txtMqttPort);
            Controls.Add(txtDeviceId);
            Name = "HeatSensor";
            Text = "Heat Sensor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDeviceId;
        private TextBox txtSSID;
        private TextBox txtWifiPass;
        private TextBox txtMqttHost;
        private TextBox txtMqttPort;
        private TextBox txtMqttPass;
        private TextBox txtMqttUser;
        private TextBox txtStaticIp;
        private RichTextBox txtLog;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
