using ExpansionQuestUI.Models.Items;
using ExpansionQuestUI.Models.Objectives;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace ExpansionQuestUI.SubPages.Objectives
{
    public partial class TreasurePage : Form
    {
        private readonly MainPage MainPage;
        public TreasurePage()
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            timeLimitTextBox.Text = "-1";
            contClassname.Text = "NSg_Quest_Container_SafeContainer";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MainPage != null)
                MainPage.Enabled = true;
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

            if (treasureData.Rows.Count <= 1)
            {
                MessageBox.Show("Необходим хотя бы один предмет в тайнике");
                return;
            }

            if (string.IsNullOrEmpty(timeLimitTextBox.Text))
                timeLimitTextBox.Text = "-1";

            if (coordinatesData.Rows.Count <= 1)
            {
                MessageBox.Show("Необходима хотя бы одна координата тайника");
                return;
            }

            #endregion

            List<List<double>> positions = new List<List<double>>();
            foreach (DataGridViewRow row in coordinatesData.Rows)
            {
                if (row.IsNewRow)
                    continue;

                positions.Add(new List<double>() { double.Parse(row.Cells[0].ToString()), double.Parse(row.Cells[1].ToString()), double.Parse(row.Cells[2].ToString()) });
            }

            List<Loot> loots = new List<Loot>();
            foreach (DataGridViewRow row in treasureData.Rows)
            {
                if (row.IsNewRow)
                    continue;

                loots.Add(new Loot() 
                { 
                    Name = row.Cells[0].ToString(),
                    Chance = double.Parse(row.Cells[1].ToString()),
                    Attachments = row.Cells[2].ToString().Split(',').ToList(),
                    QuantityPercent = int.Parse(row.Cells[3].ToString()),
                    Max = int.Parse(row.Cells[4].ToString()),
                    Min = int.Parse(row.Cells[5].ToString()),
                    Variants = row.Cells[6].ToString().Split(',').ToList(),
                });
            }

            Treasure treasure;
            try
            {
                treasure = new()
                {
                    ID = int.Parse(idTextBox.Text),
                    ObjectiveText = textTextBox.Text,
                    TimeLimit = int.Parse(timeLimitTextBox.Text),
                    MaxDistance = double.Parse(maxDidstanceTextBox.Text),
                    ShowDistance = showDistance.Checked ? 1 : 0,
                    ContainerName = contClassname.Text,
                    DigInStash = digIn.Checked ? 1 : 0,
                    MarkerName = markerNameTextBox.Text,
                    MarkerVisibility = int.Parse(markerVis.Text),
                    LootItemsAmount = int.Parse(itemsAmount.Text),
                    Positions = positions,
                    Loot = loots
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

            if (File.Exists($"Objectives/TreasureHunt/{filenameTextbox.Text}.json"))
            {
                DialogResult result = MessageBox.Show("Перезаписать файл в папке TreasureHunt?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.No)
                    return;
            }

            Directory.CreateDirectory("Objectives/TreasureHunt");
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
                };
                File.WriteAllText($"Objectives/TreasureHunt/{filenameTextbox.Text}.json", JsonSerializer.Serialize(treasure, options));
                MessageBox.Show("Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MainPage.AddObjective(treasure.ID, treasure.ObjectiveType);
            MainPage.Enabled = true;
            Close();
        }
    }
}
