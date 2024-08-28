using ExpansionQuestUI.Models.Items;
using ExpansionQuestUI.Models.Objectives;
using ExpansionQuestUI.SubPages.ItemPages;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace ExpansionQuestUI.SubPages.Objectives
{
    public partial class DeliveryPage : Form
    {
        private readonly MainPage MainPage;
        public DeliveryPage()
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            timeLimitTextBox.Text = "-1";
            maxDidstanceTextBox.Text = "20,0";
        }

        public void AddItem(CollectItem item)
        {
            itemsData.Rows.Add(item.Amount.ToString(), item.ClassName, item.QuantityPercent.ToString(), item.MinQuantityPercent.ToString());
            Update();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            Form items = new CollectItems();
            Enabled = false;
            items.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (itemsData.Rows.Count <= 1)
                return;

            foreach (DataGridViewRow row in itemsData.SelectedRows)
                if (!row.IsNewRow)
                    itemsData.Rows.Remove(row);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MainPage != null)
            {
                MainPage.Enabled = true;
                MainPage.Select();
            }
            Close();
        }

        private void addTarget_Click(object sender, EventArgs e)
        {
            #region Проверка на дурака

            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Не задан ID квеста");
                return;
            }

            if (string.IsNullOrEmpty(textTextBox.Text))
            {
                MessageBox.Show("Не задан текст задачи");
                return;
            }

            if (itemsData.Rows.Count <= 1)
            {
                MessageBox.Show("Нет необходимых предметов");
                return;
            }

            if(string.IsNullOrEmpty(maxDidstanceTextBox.Text))
                maxDidstanceTextBox.Text = "20.0";

            #endregion

            Delivery collect;
            List<CollectItem> collectItems = new();

            foreach (DataGridViewRow row in itemsData.Rows)
                if (!row.IsNewRow)
                    collectItems.Add(new CollectItem()
                    {
                        Amount = int.Parse(row.Cells[0]?.Value?.ToString()),
                        ClassName = row.Cells[1]?.Value?.ToString(),
                        QuantityPercent = int.Parse(row.Cells[2]?.Value?.ToString()),
                        MinQuantityPercent = int.Parse(row.Cells[3]?.Value?.ToString()),
                    });
            try
            {
                collect = new()
                {
                    ID = int.Parse(idTextBox.Text),
                    ObjectiveText = textTextBox.Text,
                    TimeLimit = int.Parse(timeLimitTextBox.Text),
                    Collections = collectItems,
                    ShowDistance = showDistance.Checked ? 1 : 0,
                    AddItemsToNearbyMarketZone = addZone.Checked ? 1 : 0,
                    MaxDistance = double.Parse(maxDidstanceTextBox.Text),
                    MarkerName = markerNameTextBox.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи данных, " + ex.Message);
                return;
            }

            if (string.IsNullOrEmpty(filenameTextbox.Text))
            {
                MessageBox.Show("Не указано название файла");
                filenameTextbox.BackColor = Color.OrangeRed;
                return;
            }

            if (File.Exists($"Objectives/Delivery/{filenameTextbox.Text}.json"))
            {
                DialogResult result = MessageBox.Show("Перезаписать файл в папке Delivery?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.No)
                    return;
            }

            Directory.CreateDirectory("Objectives/Delivery");
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
                };
                File.WriteAllText($"Objectives/Delivery/{filenameTextbox.Text}.json", JsonSerializer.Serialize(collect, options));
                MessageBox.Show("Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MainPage.AddObjective(collect.ID, collect.ObjectiveType);
            MainPage.Enabled = true;
            MainPage.Select();
            Close();
        }
    }
}
