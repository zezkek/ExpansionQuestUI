using ExpansionQuestUI.SubPages.Objectives;

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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MainPage != null)
                MainPage.Enabled = true;
            Close();
        }

        private void selectTraget_Click(object sender, EventArgs e)
        {
            Form form = new TargetPage();
            form.Show();
            Close();
        }

        private void selectTravel_Click(object sender, EventArgs e)
        {
            Form form = new TravelPage();
            form.Show();
            Close();
        }

        private void selectCollect_Click(object sender, EventArgs e)
        {
            Form form = new CollectPage();
            form.Show();
            Close();
        }

        private void selectDelivery_Click(object sender, EventArgs e)
        {
            Form form = new DeliveryPage();
            form.Show();
            Close();
        }

        private void selectTreasure_Click(object sender, EventArgs e)
        {
            Form form = new TreasurePage();
            form.Show();
            Close();
        }

        private void addOwn_Click(object sender, EventArgs e)
        {
            MainPage.AddObjective(int.Parse(idTextBox.Text), int.Parse(objectiveTypeTextBox.Text));
            MainPage.Enabled = true;
            Close();
        }
    }
}
