namespace ExpansionQuestUI.SubPages
{
    public partial class QuestItems : Form
    {
        private readonly MainPage Mainform;
        public QuestItems()
        {
            InitializeComponent();

            Mainform = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            ControlBox = false;
            Text = "Добавить квестовый предмет";
            questItemAmountTextBox.Text = "1";
        }

        private void closeAddQuestItemForm_Click(object sender, EventArgs e)
        {
            if (Mainform != null)
            {
                Mainform.Enabled = true;
            }
            Close();
        }

        private void addQuestItem_Click(object sender, EventArgs e)
        {
            if (Mainform != null)
            {
                Mainform.AddQuestItem(questItemClassnameTextBox.Text, int.Parse(questItemAmountTextBox.Text));
                questItemClassnameTextBox.Text = null;
                questItemAmountTextBox.Text = "1";
            }
        }

        private void questItemAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
