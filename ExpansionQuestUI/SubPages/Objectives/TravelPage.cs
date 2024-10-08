﻿using ExpansionQuestUI.Models.Objectives;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace ExpansionQuestUI.SubPages.Objectives
{
    public partial class TravelPage : Form
    {
        MainPage MainPage;
        public TravelPage()
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            timeLimitTextBox.Text = "-1";
            radiusTextBox.Text = "-1,0";
            coordsTextBox.Text = "0.0, 0.0, 0.0";
            onEnter.Checked = true;
        }

        public TravelPage(Travel travel, string filename)
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            idTextBox.Text = travel.ID.ToString();
            textTextBox.Text = travel.ObjectiveText;
            timeLimitTextBox.Text = travel.TimeLimit.ToString();
            coordsTextBox.Text = string.Join(", ", travel.Position);
            radiusTextBox.Text = travel.MaxDistance.ToString();
            markerNameTextBox.Text = travel.MarkerName;
            showDistance.Checked = travel.ShowDistance != 0;
            onEnter.Checked = travel.TriggerOnEnter != 0;
            onExit.Checked = travel.TriggerOnExit != 0;
            filenameTextBox.Text = filename;
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

            if (string.IsNullOrEmpty(timeLimitTextBox.Text))
                timeLimitTextBox.Text = "-1";

            if (string.IsNullOrEmpty(coordsTextBox.Text) || string.Equals(coordsTextBox.Text, "0.0, 0.0, 0.0"))
            {
                MessageBox.Show("Не заданы координаты");
                return;
            }

            if (string.IsNullOrEmpty(radiusTextBox.Text))
            {
                MessageBox.Show("Не задан радиус области");
                return;
            }

            if (string.IsNullOrEmpty(markerNameTextBox.Text))
                markerNameTextBox.Text = "";

            if (!(onEnter.Checked ^ onExit.Checked))
            {
                MessageBox.Show("Необходимо выбрать когда срабатывает триггер задачи(либо на входе, либо на выходе)");
                return;
            }

            #endregion

            Travel travel;
            try
            {
                var strCoords = coordsTextBox.Text.Replace(" ", string.Empty);
                var strCoordsList = strCoords.Split(',').ToList();
                for (int i = 0; i < 3; i++)
                    strCoordsList[i] = strCoordsList[i].Replace(".", ",");

                travel = new()
                {
                    ID = int.Parse(idTextBox.Text),
                    ObjectiveText = textTextBox.Text,
                    TimeLimit = int.Parse(timeLimitTextBox.Text),
                    Position = strCoordsList.Select(x=>double.Parse(x)).ToList(),
                    MaxDistance = double.Parse(radiusTextBox.Text),
                    MarkerName = markerNameTextBox.Text,
                    ShowDistance = showDistance.Checked ? 1 : 0,
                    TriggerOnEnter = onEnter.Checked ? 1 : 0,
                    TriggerOnExit = onExit.Checked ? 1 : 0
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи данных, " + ex.Message);
                return;
            }

            if (string.IsNullOrEmpty(filenameTextBox.Text))
            {
                MessageBox.Show("Не указано название файла");
                filenameTextBox.BackColor = Color.OrangeRed;
                return;
            }

            if (File.Exists($"Objectives/Travel/{filenameTextBox.Text}.json"))
            {
                DialogResult result = MessageBox.Show("Перезаписать файл в папке Travel?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.No)
                    return;
            }

            Directory.CreateDirectory("Objectives/Travel");
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
                };
                File.WriteAllText($"Objectives/Travel/{filenameTextBox.Text}.json", JsonSerializer.Serialize(travel, options));
                MessageBox.Show("Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MainPage.AddObjective(travel.ID, travel.ObjectiveType);
            MainPage.Enabled = true; 
            MainPage.Select();
            Close();
        }

        private void xTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void yTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void zTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void radiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
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
    }
}
