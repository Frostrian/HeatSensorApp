using AttackSimulator.AttackSimulator;

namespace AttackSimulator
{
    public partial class AttackSimulator : Form 
    {
        public AttackSimulator()
        {
            InitializeComponent();
            cmbAttackType.SelectedIndex = 0;
        }

        private async void btnStartAttack_Click(object sender, EventArgs e)
        {
            string deviceId = txtDeviceId.Text;
            int rate = (int)numRate.Value;
            string attackType = cmbAttackType.SelectedItem.ToString();

            IAttackModule attack = attackType switch
            {
                "Flood" => new FloodAttack(deviceId, rate, Log),
                _ => null
            };

            if (attack != null)
            {
                Log($"[SYSTEM] Baþlatýldý: {attackType} ({deviceId})");
                await attack.ExecuteAsync();
                Log("[SYSTEM] Saldýrý tamamlandý.");
            }
        }

        private void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            rtbLog.AppendText($"[{timestamp}] {message}\n");
        }
    }
}
