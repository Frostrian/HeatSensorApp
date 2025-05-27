namespace AttackSimulator
{
    partial class AttackSimulator
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
            cmbAttackType = new ComboBox();
            txtDeviceId = new TextBox();
            rtbLog = new RichTextBox();
            SuspendLayout();
            // 
            // cmbAttackType
            // 
            cmbAttackType.FormattingEnabled = true;
            cmbAttackType.Location = new Point(67, 12);
            cmbAttackType.Name = "cmbAttackType";
            cmbAttackType.Size = new Size(121, 23);
            cmbAttackType.TabIndex = 0;
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new Point(67, 41);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.Size = new Size(100, 23);
            txtDeviceId.TabIndex = 1;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(21, 147);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(214, 265);
            rtbLog.TabIndex = 2;
            rtbLog.Text = "";
            // 
            // AttackSimulator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbLog);
            Controls.Add(txtDeviceId);
            Controls.Add(cmbAttackType);
            Name = "AttackSimulator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAttackType;
        private TextBox txtDeviceId;
        private RichTextBox rtbLog;
    }
}
