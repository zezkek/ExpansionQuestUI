﻿using ExpansionQuestUI.Models.Items;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            timeLimitTextBox.Text = "-1";
            contClassname.Text = "NSg_Quest_Container_SafeContainer";
            markerVis.Text = "4";
            maxDidstanceTextBox.Text = "20.0";
        }

        public TreasurePage(Treasure treasure, string filename)
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            idTextBox.Text = treasure.ID.ToString();
            textTextBox.Text = treasure.ObjectiveText;
            timeLimitTextBox.Text = treasure.TimeLimit.ToString();
            contClassname.Text = treasure.ContainerName;
            markerNameTextBox.Text = treasure.MarkerName;
            markerVis.Text = treasure.MarkerVisibility.ToString();
            filenameTextbox.Text = filename;
            itemsAmount.Text = treasure.LootItemsAmount.ToString();
            maxDidstanceTextBox.Text = treasure.MaxDistance.ToString();

            showDistance.Checked = treasure.ShowDistance != 0;
            digIn.Checked = treasure.DigInStash != 0;

            foreach (var coord in treasure.Positions)
                coordinatesData.Rows.Add(coord[0], coord[1], coord[2]);

            foreach (var item in treasure.Loot)
            {
                var attachments = item.Attachments != null ? string.Join(",", item.Attachments) : string.Empty;
                var variants = item.Variants != null ? string.Join(",", item.Variants) : string.Empty;

                treasureData.Rows.Add(item.Name, item.Chance.ToString(), attachments, item.QuantityPercent.ToString(), item.Max.ToString(), item.Min.ToString(), variants);
            }
        }

            public void AddLoot(Loot loot)
        {
            var attachments = loot.Attachments.Any() ? string.Join(",", loot.Attachments) : string.Empty;
            var variants = loot.Variants.Any() ? string.Join(",", loot.Variants) : string.Empty;
            treasureData.Rows.Add(loot.Name, loot.Chance.ToString(), attachments, loot.QuantityPercent.ToString(), loot.Max.ToString(), loot.Min.ToString(), variants);
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
                    MaxDistance = double.Parse(maxDidstanceTextBox.Text.Replace(".", ",")),
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
            MainPage.Select();
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

        private void removeLoot_Click(object sender, EventArgs e)
        {
            if (treasureData.Rows.Count <= 1)
                return;

            foreach (DataGridViewRow row in treasureData.SelectedRows)
                if (!row.IsNewRow)
                    treasureData.Rows.Remove(row);
        }

        private void removeCoords_Click(object sender, EventArgs e)
        {
            if (coordinatesData.Rows.Count <= 1)
                return;

            foreach (DataGridViewRow row in coordinatesData.SelectedRows)
                if (!row.IsNewRow)
                    coordinatesData.Rows.Remove(row);
        }

        private void addLoot_Click(object sender, EventArgs e)
        {
            Form loot = new ItemPages.Loot();
            Enabled = false;
            loot.Show();
        }

        private void addCoords_Click(object sender, EventArgs e)
        {
            var strCoords = coordsTextBox.Text.Replace(" ", string.Empty);
            var strCoordsList = strCoords.Split(',').ToList();
            for (int i = 0; i < 3; i++)
                strCoordsList[i] = strCoordsList[i].Replace(".", ",");

            coordinatesData.Rows.Add(strCoordsList[0], strCoordsList[1], strCoordsList[2]);
        }
    }
}
