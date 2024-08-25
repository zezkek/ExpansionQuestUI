namespace ExpansionQuestUI.SubPages
{
    public partial class Rewards : Form
    {
        private readonly MainPage Mainform;
        public Rewards()
        {
            InitializeComponent();

            ControlBox = false;
            Mainform = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            rewardAmountTextBox.Text = "1";
            rewardDamageTextBox.Text = "0";
            rewardQuestTextBox.Text = "-1";
            rewardChanceTextBox.Text = "1,0";
        }

        private void addReward_Click(object sender, EventArgs e)
        {
            if (Mainform != null)
            {
                Mainform.AddReward(rewardClassnameTextBox.Text, int.Parse(rewardAmountTextBox.Text), rewardAttachmentsTextBox.Text.Split(",").ToList(), int.Parse(rewardDamageTextBox.Text), int.Parse(rewardQuestTextBox.Text), double.Parse(rewardChanceTextBox.Text.Replace(".", ",")));
                rewardClassnameTextBox.Text = null;
                rewardAmountTextBox.Text = "1";
                rewardAttachmentsTextBox.Text = null;
                rewardDamageTextBox.Text = "0";
                rewardQuestTextBox.Text = "-1";
                rewardChanceTextBox.Text = "1,0";
            }
        }

        private void closeReward_Click(object sender, EventArgs e)
        {
            if (Mainform != null)
            {
                Mainform.Enabled = true;
            }
            Close();
        }

        private void rewardAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rewardAttachmentsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rewardDamageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rewardQuestTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| char.Equals('-', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rewardChanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.Equals('.', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
