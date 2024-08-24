using ExpansionQuestUI.Models;
using System.Text.Json;

namespace ExpansionQuestUI.SubPages
{
    public partial class FilenamePage : Form
    {
        public FilenamePage()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void cancelFileCreateButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filenameTextbox.Text))
            {
                MessageBox.Show("Не указано название файла");
                return;
            }

            FileStream file;
            Directory.CreateDirectory("Quests");

            if (File.Exists($"Quests/{filenameTextbox.Text}.json"))
            {
                MessageBox.Show("Квест с таким названием уже существует");
                return;
            }

            try
            {
                file = File.Create($"Quests/{filenameTextbox.Text}.json");
                file.Close();

                var options = new JsonSerializerOptions { WriteIndented = true };
                Quest quest = new Quest();
                File.WriteAllText($"Quests/{filenameTextbox.Text}.json", JsonSerializer.Serialize(quest, options));
            }
            catch
            {
                MessageBox.Show("Не удалось создать файл");
                return;
            }

            var mainform = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            if (mainform != null)
            {
                mainform.SetCurrentFileName($"Quests/{filenameTextbox.Text}.json");
                mainform.InitQuest(new Quest());
                mainform.DisableBlock();
                mainform.Enabled = true;
            }
            Close();
        }
    }
}
