using ExpansionQuestUI.SubPages.Objectives;

namespace ExpansionQuestUI.SubPages.ItemPages
{
    public partial class Loot : Form
    {
        private readonly TreasurePage treasurePage;
        public Loot()
        {
            InitializeComponent();

            ControlBox = false;
            treasurePage = Application.OpenForms.OfType<TreasurePage>().FirstOrDefault();
            InitFields();
        }

        private void InitFields()
        {
            rewardClassnameTextBox.Text = string.Empty;
            rewardAttachmentsTextBox.Text = string.Empty;
            variantsTextBox.Text = string.Empty;
            chanceTextBox.Text = "1.0";
            quantityPercentTextBox.Text = "-1";
            maxTextBox.Text = "-1";
            minTextBox.Text = "1";
        }

        private void addReward_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rewardClassnameTextBox.Text))
            {
                MessageBox.Show("Не задан класснейм");
                return;
            }

            if (string.IsNullOrEmpty(chanceTextBox.Text))
                chanceTextBox.Text = "1.0";

            if (string.IsNullOrEmpty(maxTextBox.Text))
                maxTextBox.Text = "-1";

            if (string.IsNullOrEmpty(minTextBox.Text))
                minTextBox.Text = "1";

            if (string.IsNullOrEmpty(quantityPercentTextBox.Text))
                quantityPercentTextBox.Text = "-1";

            Models.Items.Loot loot;
            try
            {
                loot = new Models.Items.Loot()
                {
                    Name = rewardClassnameTextBox.Text,
                    Chance = double.Parse(chanceTextBox.Text),
                    Attachments = rewardAttachmentsTextBox.Text.Split(",").ToList(),
                    QuantityPercent = int.Parse(quantityPercentTextBox.Text),
                    Max = int.Parse(maxTextBox.Text),
                    Min = int.Parse(minTextBox.Text),
                    Variants = variantsTextBox.Text.Split(",").ToList(),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи данных, " + ex.Message);
                return;
            }


            InitFields();
        }

        private void closeReward_Click(object sender, EventArgs e)
        {
            treasurePage.Enabled = true;
            Close();
        }
    }
}
