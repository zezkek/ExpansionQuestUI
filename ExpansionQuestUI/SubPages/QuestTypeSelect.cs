namespace ExpansionQuestUI.SubPages
{
    public partial class QuestTypeSelect : Form
    {
        MainPage MainPage;
        public QuestTypeSelect()
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MainPage != null)
                MainPage.Enabled = true;
            Close();
        }

        private void selectTraget_Click(object sender, EventArgs e)
        {

        }
    }
}
