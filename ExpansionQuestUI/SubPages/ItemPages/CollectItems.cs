using ExpansionQuestUI.SubPages.Objectives;

namespace ExpansionQuestUI.SubPages.ItemPages
{
    public partial class CollectItems : Form
    {
        private readonly CollectPage collectPage;
        private readonly DeliveryPage deliveryPage;
        public CollectItems()
        {
            InitializeComponent();

            collectPage = Application.OpenForms.OfType<CollectPage>().FirstOrDefault();
            deliveryPage = Application.OpenForms.OfType<DeliveryPage>().FirstOrDefault();
            amountTextBox.Text = "1";
            quantityTexBox.Text = "-1";
            minQuantityTextBox.Text = "-1";
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (collectPage != null)
                collectPage.Enabled = true;
            else
                deliveryPage.Enabled = true;
            Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Models.Items.CollectItem()
                {
                    Amount = int.Parse(amountTextBox.Text),
                    ClassName = classNameTextBox.Text,
                    QuantityPercent = int.Parse(quantityTexBox.Text),
                    MinQuantityPercent = int.Parse(minQuantityTextBox.Text),
                };
                if(collectPage != null) 
                    collectPage.AddItem(item);
                else
                    deliveryPage.AddItem(item);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка при добавлении данных " + ex.Message);
            }

            amountTextBox.Text = "1";
            quantityTexBox.Text = "-1";
            minQuantityTextBox.Text = "-1";
            classNameTextBox.Text = "";
        }
    }
}
