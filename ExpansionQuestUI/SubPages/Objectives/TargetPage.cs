using ExpansionQuestUI.Models.Objectives;
using System.Text.Json;

namespace ExpansionQuestUI.SubPages.Objectives
{
    public partial class TargetPage : Form
    {
        MainPage MainPage;
        public TargetPage()
        {
            InitializeComponent();
            ControlBox = false;
            MainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MainPage != null)
                MainPage.Enabled = true;
            Close();
        }

        private void addTarget_Click(object sender, EventArgs e)
        {
            Target target;
            try
            {
                target = new()
                {
                    ID = int.Parse(idTextBox.Text),
                    ObjectiveText = textTextBox.Text,
                    TimeLimit = int.Parse(timeLimitTextBox.Text),
                    Position = [double.Parse(xTextBox.Text), double.Parse(yTextBox.Text), double.Parse(zTextBox.Text)],
                    MaxDistance = double.Parse(maxdisTextBox.Text),
                    MinDistance = double.Parse(minDIstTextBox.Text),
                    Amount = int.Parse(amountTextBox.Text),
                    ClassNames = classnamesTextBox.Text.Split(",").ToList(),
                    CountSelfKill = selfkill.Checked ? 1 : 0,
                    AllowedWeapons = allowedWeaponsTextBox.Text.Split(",").ToList(),
                    ExcludedClassNames = excludedTextBox.Text.Split(",").ToList(),
                    CountAIPlayers = countAI.Checked ? 1 : 0,
                    AllowedTargetFactions = allowedTargetFactionsTextBox.Text.Split(",").ToList(),
                    AllowedDamageZones = allowedDamageZonesTextBox.Text.Split(",").ToList()
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при записи данныхб, " + ex.Message);
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
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText($"Objectives/Target/{filenameTextbox.Text}.json", JsonSerializer.Serialize(target, options));
                MessageBox.Show("Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MainPage.AddObjective(target.ID, target.ObjectiveType);
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
