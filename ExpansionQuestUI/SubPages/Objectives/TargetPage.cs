using ExpansionQuestUI.Models.Objectives;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace ExpansionQuestUI.SubPages.Objectives
{
    public partial class TargetPage : Form
    {
        private readonly MainPage MainPage;
        public TargetPage()
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            timeLimitTextBox.Text = "-1";
            maxdisTextBox.Text = "-1,0";
            minDIstTextBox.Text = "-1,0";
            coordsTextBox.Text = "0.0, 0.0, 0.0";
            amountTextBox.Text = "1";
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

            if (string.IsNullOrEmpty(classnamesTextBox.Text))
            {
                MessageBox.Show("Не заданы класснеймы целей");
                return;
            }

            if (string.IsNullOrEmpty(timeLimitTextBox.Text))
                timeLimitTextBox.Text = "-1";

            if (string.IsNullOrEmpty(coordsTextBox.Text))
                coordsTextBox.Text = "0.0, 0.0, 0.0";

            if (string.IsNullOrEmpty(maxdisTextBox.Text))
                maxdisTextBox.Text = "-1,0";

            if (string.IsNullOrEmpty(minDIstTextBox.Text))
                minDIstTextBox.Text = "-1,0";

            if (string.IsNullOrEmpty(amountTextBox.Text))
                amountTextBox.Text = "1";

            #endregion

            Target target;
            try
            {
                var classNames = classnamesTextBox.Text.Split(",").ToList();
                if (string.IsNullOrEmpty(classNames[0]))
                    classNames = new List<string>();

                var allowedWeapons = allowedWeaponsTextBox.Text.Split(",").ToList();
                if (string.IsNullOrEmpty(allowedWeapons[0]))
                    allowedWeapons = new List<string>();

                var excludedClassNames = excludedTextBox.Text.Split(",").ToList();
                if (string.IsNullOrEmpty(excludedClassNames[0]))
                    excludedClassNames = new List<string>();

                var allowedTargetFactions = allowedTargetFactionsTextBox.Text.Split(",").ToList();
                if (string.IsNullOrEmpty(allowedTargetFactions[0]))
                    allowedTargetFactions = new List<string>();

                var allowedDamageZones = allowedDamageZonesTextBox.Text.Split(",").ToList();
                if (string.IsNullOrEmpty(allowedDamageZones[0]))
                    allowedDamageZones = new List<string>();

                var strCoords = coordsTextBox.Text.Replace(" ", string.Empty);
                var strCoordsList = strCoords.Split(',').ToList();
                for (int i = 0; i < 3; i++)
                    strCoordsList[i] = strCoordsList[i].Replace(".", ",");

                target = new()
                {
                    ID = int.Parse(idTextBox.Text),
                    ObjectiveText = textTextBox.Text,
                    TimeLimit = int.Parse(timeLimitTextBox.Text),
                    Position = strCoordsList.Select(x => double.Parse(x)).ToList(),
                    MaxDistance = double.Parse(maxdisTextBox.Text),
                    MinDistance = double.Parse(minDIstTextBox.Text),
                    Amount = int.Parse(amountTextBox.Text),
                    ClassNames = classNames,
                    CountSelfKill = selfkill.Checked ? 1 : 0,
                    AllowedWeapons = allowedWeapons,
                    ExcludedClassNames = excludedClassNames,
                    CountAIPlayers = countAI.Checked ? 1 : 0,
                    AllowedTargetFactions = allowedTargetFactions,
                    AllowedDamageZones = allowedDamageZones
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

            if (File.Exists($"Objectives/Target/{filenameTextbox.Text}.json"))
            {
                DialogResult result = MessageBox.Show("Перезаписать файл в папке Target?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.No)
                    return;
            }

            Directory.CreateDirectory("Objectives/Target");
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
                };
                File.WriteAllText($"Objectives/Target/{filenameTextbox.Text}.json", JsonSerializer.Serialize(target, options));
                MessageBox.Show("Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MainPage.AddObjective(target.ID, target.ObjectiveType);
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

        private void maxdisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void minDIstTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void timeLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
