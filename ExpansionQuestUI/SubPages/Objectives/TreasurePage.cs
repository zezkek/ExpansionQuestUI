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
            markerVis.Text = "4";
            maxDidstanceTextBox.Text = "20.0";
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

            Treasure treasure;
            try
            {
                List<List<double>> positions = new List<List<double>>();
                foreach (DataGridViewRow row in coordinatesData.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    positions.Add(new List<double>() { double.Parse(row.Cells[0].Value.ToString()), double.Parse(row.Cells[1].Value.ToString()), double.Parse(row.Cells[2].Value.ToString()) });
                }

                List<Loot> loots = new List<Loot>();
                foreach (DataGridViewRow row in treasureData.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    var attachments = row?.Cells[2]?.Value?.ToString()?.Split(',')?.ToList();
                    if (string.IsNullOrEmpty(attachments[0]))
                        attachments = new List<string>();

                    var variants = row.Cells[6]?.Value?.ToString().Split(',').ToList();
                    if (string.IsNullOrEmpty(variants[0]))
                        variants = new List<string>();

                    var loot = new Loot()
                    {
                        Name = row?.Cells[0]?.Value?.ToString(),
                        Chance = double.Parse(row?.Cells[1]?.Value?.ToString()),
                        Attachments = attachments,
                        QuantityPercent = int.Parse(row?.Cells[3]?.Value?.ToString()),
                        Max = int.Parse(row?.Cells[4]?.Value?.ToString()),
                        Min = int.Parse(row?.Cells[5]?.Value?.ToString()),
                        Variants = variants,
                    };

                    loot.Attachments ??= new List<string>();
                    loot.Variants ??= new List<string>();

                    loots.Add(loot);
                }

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

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void itemsAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void maxDidstanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
