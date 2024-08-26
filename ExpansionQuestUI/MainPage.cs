using ExpansionQuestUI.Models;
using ExpansionQuestUI.Models.Items;
using ExpansionQuestUI.SubPages;
using System.Data;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace ExpansionQuestUI
{
    public partial class MainPage : Form
    {
        public string CurrentFile = string.Empty;
        public Quest CurrentQuest = new Quest();
        public MainPage()
        {
            InitializeComponent();

            EnableBlock();

            openQuest.FileName = "Роуг чурка";
            openQuest.Filter = "Файлы квестов (*.json)|*.json";
            openQuest.DefaultExt = "json";
            openQuest.AddExtension = true;
            openQuest.InitialDirectory = Directory.GetCurrentDirectory();
            openQuest.RestoreDirectory = false;
        }

        public void SetCurrentFileName(string fileName)
        {
            CurrentFile = fileName;
            Text = $"Редактор квестов by fkn_goose (текущий файл - {fileName})";
        }

        public void InitQuest(Quest quest)
        {
            //strings
            CurrentQuest = quest;
            questTitleTextBox.Text = quest.Title;
            startDialogTextBox.Text = quest.Descriptions[0];
            againDialogTextBox.Text = quest.Descriptions[1];
            endDialogTextBox.Text = quest.Descriptions[2];
            objTextBox.Text = quest.ObjectiveText;
            mapFileNameTextBox.Text = quest.ObjectSetFileName;

            //ids and numbers
            idTextBox.Text = quest.ID.ToString();
            followUpQuestIdTextBox.Text = quest.FollowUpQuest.ToString();
            rewardBehTexbox.Text = quest.RewardBehavior.ToString();
            giverNPCTextBox.Text = string.Join(",", quest.QuestGiverIDs);
            turninNPCIDTexBox.Text = string.Join(",", quest.QuestTurnInIDs);
            colorIdTextBox.Text = quest.QuestColor.ToString();
            repQuestTextBox.Text = quest.ReputationReward.ToString();
            repNeedQuestTextBox.Text = quest.ReputationRequirement.ToString();
            prevQuestTextBox.Text = string.Join(",", quest.PreQuestIDs);
            randomRewardAmountTextBox.Text = quest.RandomRewardAmount.ToString();

            //bools
            repeatable.Checked = quest.Repeatable != 0;
            isDaily.Checked = quest.IsDailyQuest != 0;
            isWeekly.Checked = quest.IsWeeklyQuest != 0;
            cancelOnDeath.Checked = quest.CancelQuestOnPlayerDeath != 0;
            autocomplete.Checked = quest.Autocomplete != 0;
            isGroup.Checked = quest.IsGroupQuest != 0;
            selectReward.Checked = quest.NeedToSelectReward != 0;
            randomReward.Checked = quest.RandomReward != 0;
            rewardForOwner.Checked = quest.RewardsForGroupOwnerOnly != 0;
            achievment.Checked = quest.IsAchievement != 0;
            seqQuest.Checked = quest.SequentialObjectives != 0;
            needQuestItems.Checked = quest.PlayerNeedQuestItems != 0;
            deleteQuestItems.Checked = quest.DeleteQuestItems != 0;

            //structures
            foreach (var questItem in quest.QuestItems)
                questItemsData.Rows.Add(questItem.ClassName, questItem.Amount.ToString());

            foreach (var reward in quest.Rewards)
                rewardsData.Rows.Add(reward.ClassName, reward.Amount.ToString(), string.Join(",", reward.Attachments), reward.DamagePercent.ToString(), reward.QuestID.ToString(), reward.Chance.ToString());

            foreach (var objective in quest.Objectives)
                objectivesData.Rows.Add(objective.ID.ToString(), objective.ObjectiveType.ToString());
        }

        public Quest SaveCurrentQuest()
        {
            List<QuestItem> questItems = new List<QuestItem>();
            if (questItemsData.Rows.Count > 1)
                for (int i = 0; i < questItemsData.Rows.Count - 1; i++)
                {
                    questItems.Add(new QuestItem()
                    {
                        ClassName = questItemsData?.Rows[i]?.Cells[0]?.Value?.ToString(),
                        Amount = int.Parse(questItemsData?.Rows[i]?.Cells[1]?.Value?.ToString())
                    });
                }

            List<Reward> rewards = new List<Reward>();
            if (rewardsData.Rows.Count > 1)
                for (int i = 0; i < rewardsData.Rows.Count - 1; i++)
                {
                    rewards.Add(new Reward()
                    {
                        ClassName = rewardsData.Rows[i]?.Cells[0].Value.ToString(),
                        Amount = int.Parse(rewardsData.Rows[i]?.Cells[1].Value.ToString()),
                        Attachments = rewardsData.Rows[i]?.Cells[2].Value.ToString().Split(',').ToList(),
                        DamagePercent = int.Parse(rewardsData.Rows[i]?.Cells[3].Value.ToString()),
                        QuestID = int.Parse(rewardsData.Rows[i]?.Cells[4].Value.ToString()),
                        Chance = double.Parse(rewardsData.Rows[i]?.Cells[5].Value.ToString())
                    });
                }

            List<Objective> objectives = new List<Objective>();
            if (objectivesData.Rows.Count > 1)
                for (int i = 0; i < objectivesData.Rows.Count - 1; i++)
                {
                    objectives.Add(new Objective()
                    {
                        ID = int.Parse(objectivesData.Rows[i]?.Cells[0].Value.ToString()),
                        ObjectiveType = int.Parse(objectivesData.Rows[i]?.Cells[1].Value.ToString()),
                    });
                }

            try
            {
                Quest quest = new()
                {
                    ID = int.Parse(idTextBox.Text),
                    Title = questTitleTextBox.Text,
                    Descriptions = new List<string>() { startDialogTextBox.Text, againDialogTextBox.Text, endDialogTextBox.Text },
                    ObjectiveText = objTextBox.Text,
                    FollowUpQuest = int.Parse(followUpQuestIdTextBox.Text),
                    Repeatable = repeatable.Checked ? 1 : 0,
                    IsDailyQuest = isDaily.Checked ? 1 : 0,
                    IsWeeklyQuest = isWeekly.Checked ? 1 : 0,
                    CancelQuestOnPlayerDeath = cancelOnDeath.Checked ? 1 : 0,
                    Autocomplete = autocomplete.Checked ? 1 : 0,
                    IsGroupQuest = isGroup.Checked ? 1 : 0,
                    ObjectSetFileName = mapFileNameTextBox.Text,
                    QuestItems = questItems,
                    Rewards = rewards,
                    NeedToSelectReward = selectReward.Checked ? 1 : 0,
                    RandomReward = randomReward.Checked ? 1 : 0,
                    RandomRewardAmount = int.Parse(randomRewardAmountTextBox.Text),
                    RewardsForGroupOwnerOnly = rewardForOwner.Checked ? 1 : 0,
                    RewardBehavior = int.Parse(rewardBehTexbox.Text),
                    QuestGiverIDs = giverNPCTextBox.Text.Split(',').Select(x => int.Parse(x)).ToList(),
                    QuestTurnInIDs = turninNPCIDTexBox.Text.Split(',').Select(x => int.Parse(x)).ToList(),
                    IsAchievement = achievment.Checked ? 1 : 0,
                    Objectives = objectives,
                    QuestColor = int.Parse(colorIdTextBox.Text),
                    ReputationReward = int.Parse(repQuestTextBox.Text),
                    ReputationRequirement = int.Parse(repNeedQuestTextBox.Text),
                    PreQuestIDs = prevQuestTextBox.Text.Split(",").Select(x => int.Parse(x)).ToList(),
                    PlayerNeedQuestItems = needQuestItems.Checked ? 1 : 0,
                    DeleteQuestItems = deleteQuestItems.Checked ? 1 : 0,
                    SequentialObjectives = seqQuest.Checked ? 1 : 0,
                };

                CurrentQuest = quest;
                return quest;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Quest nullquest = null;
            return nullquest;
        }

        public void DisableBlock()
        {
            idTextBox.Enabled = true;
            followUpQuestIdTextBox.Enabled = true;
            rewardBehTexbox.Enabled = true;
            giverNPCTextBox.Enabled = true;
            turninNPCIDTexBox.Enabled = true;
            colorIdTextBox.Enabled = true;
            repQuestTextBox.Enabled = true;
            repNeedQuestTextBox.Enabled = true;
            prevQuestTextBox.Enabled = true;
            questTitleTextBox.Enabled = true;
            startDialogTextBox.Enabled = true;
            againDialogTextBox.Enabled = true;
            endDialogTextBox.Enabled = true;
            repeatable.Enabled = true;
            isDaily.Enabled = true;
            isWeekly.Enabled = true;
            cancelOnDeath.Enabled = true;
            autocomplete.Enabled = true;
            isGroup.Enabled = true;
            selectReward.Enabled = true;
            randomReward.Enabled = true;
            rewardForOwner.Enabled = true;
            achievment.Enabled = true;
            seqQuest.Enabled = true;
            needQuestItems.Enabled = true;
            deleteQuestItems.Enabled = true;
            objTextBox.Enabled = true;
            mapFileNameTextBox.Enabled = true;
            addQuestItem.Enabled = true;
            deleteQuestItem.Enabled = true;
            questItemsData.Enabled = true;
            addReward.Enabled = true;
            removeReward.Enabled = true;
            rewardsData.Enabled = true;
            rewardBehTexbox.Enabled = true;
            addObjective.Enabled = true;
            removeObjective.Enabled = true;
            objectivesData.Enabled = true;
            randomRewardAmountTextBox.Enabled = true;
        }

        public void EnableBlock()
        {
            idTextBox.Enabled = false;
            followUpQuestIdTextBox.Enabled = false;
            rewardBehTexbox.Enabled = false;
            giverNPCTextBox.Enabled = false;
            turninNPCIDTexBox.Enabled = false;
            colorIdTextBox.Enabled = false;
            repQuestTextBox.Enabled = false;
            repNeedQuestTextBox.Enabled = false;
            prevQuestTextBox.Enabled = false;
            questTitleTextBox.Enabled = false;
            startDialogTextBox.Enabled = false;
            againDialogTextBox.Enabled = false;
            endDialogTextBox.Enabled = false;
            repeatable.Enabled = false;
            isDaily.Enabled = false;
            isWeekly.Enabled = false;
            cancelOnDeath.Enabled = false;
            autocomplete.Enabled = false;
            isGroup.Enabled = false;
            selectReward.Enabled = false;
            randomReward.Enabled = false;
            rewardForOwner.Enabled = false;
            achievment.Enabled = false;
            seqQuest.Enabled = false;
            needQuestItems.Enabled = false;
            deleteQuestItems.Enabled = false;
            objTextBox.Enabled = false;
            mapFileNameTextBox.Enabled = false;
            addQuestItem.Enabled = false;
            deleteQuestItem.Enabled = false;
            questItemsData.Enabled = false;
            addReward.Enabled = false;
            removeReward.Enabled = false;
            rewardsData.Enabled = false;
            rewardBehTexbox.Enabled = false;
            addObjective.Enabled = false;
            removeObjective.Enabled = false;
            objectivesData.Enabled = false;
            randomRewardAmountTextBox.Enabled = false;
        }

        public void AddQuestItem(string classname, int amount)
        {
            questItemsData.Rows.Add(classname, amount.ToString());
            Update();
        }

        public void AddReward(string classname, int amount, List<string> attachments, int damagePercent, int questID, double chance)
        {
            rewardsData.Rows.Add(classname, amount.ToString(), string.Join(",", attachments), damagePercent.ToString(), questID.ToString(), chance.ToString());
            Update();
        }

        public void AddObjective(int id, int type)
        {
            objectivesData.Rows.Add(id.ToString(), type.ToString());
            Update();
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void followUpQuestIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rewardBehTexbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void giverNPCTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void turninNPCIDTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void colorIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void repQuestTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void repNeedQuestTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void prevQuestTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.Equals(',', e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openQuest.ShowDialog(this) == DialogResult.Cancel)
                return;

            try
            {
                Stream stream = openQuest.OpenFile();
                using StreamReader reader = new(stream);
                string? str = reader.ReadToEnd();
                var quest = JsonSerializer.Deserialize<Quest>(str);
                if (quest == null)
                {
                    MessageBox.Show("Ошибка при чтении данных из файла");
                    return;

                }

                SetCurrentFileName($"{openQuest.FileName}");
                InitQuest(quest);
                DisableBlock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            Form filepage = new FilenamePage();
            Enabled = false;
            filepage.Show();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            var quest = SaveCurrentQuest();
            if (quest == null)
            {
                MessageBox.Show("Ошибка при сохранении файла");
                return;
            }
            var filename = Path.GetFileName(CurrentFile);

            if (File.Exists($"Quests/{filename}"))
            {
                DialogResult result = MessageBox.Show("Перезаписать файл в папке Quests?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.No)
                    return;
            }

            Directory.CreateDirectory("Quests");
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
                };
                File.WriteAllText($"Quests/{filename}", JsonSerializer.Serialize(quest, options));
                MessageBox.Show("Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addQuestItem_Click(object sender, EventArgs e)
        {
            Form questItems = new QuestItems();
            Enabled = false;
            questItems.Show();
        }

        private void addReward_Click(object sender, EventArgs e)
        {
            Form rewards = new Rewards();
            Enabled = false;
            rewards.Show();
        }

        private void deleteQuestItem_Click(object sender, EventArgs e)
        {
            if (questItemsData.SelectedRows.Count < 1)
                return;

            foreach (DataGridViewRow row in questItemsData.SelectedRows)
                if (!row.IsNewRow)
                    questItemsData.Rows.Remove(row);
        }

        private void removeReward_Click(object sender, EventArgs e)
        {
            if (rewardsData.SelectedRows.Count < 1)
                return;

            foreach (DataGridViewRow row in rewardsData.SelectedRows)
                if (!row.IsNewRow)
                    rewardsData.Rows.Remove(row);
        }

        private void addObjective_Click(object sender, EventArgs e)
        {
            Form questselect = new QuestTypeSelect();
            Enabled = false;
            questselect.Show();
        }
    }
}
