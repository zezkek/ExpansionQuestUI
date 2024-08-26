using ExpansionQuestUI.Models;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace ExpansionQuestUI.SubPages
{
    public partial class FilenamePage : Form
    {
        private readonly MainPage mainPage;
        public FilenamePage()
        {
            mainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            InitializeComponent();
            ControlBox = false;
        }

        private void cancelFileCreateButton_Click(object sender, EventArgs e)
        {
            mainPage.DisableBlock();
            mainPage.Enabled = true;
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

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
                };
                Quest quest = new Quest();
                File.WriteAllText($"Quests/{filenameTextbox.Text}.json", JsonSerializer.Serialize(quest, options));
            }
            catch
            {
                MessageBox.Show("Не удалось создать файл");
                return;
            }

            if (mainPage != null)
            {
                mainPage.SetCurrentFileName($"Quests/{filenameTextbox.Text}.json");
                mainPage.InitQuest(new Quest());
                mainPage.DisableBlock();
                mainPage.Enabled = true;
            }
            Close();
        }
    }
}
