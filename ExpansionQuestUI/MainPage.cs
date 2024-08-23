namespace ExpansionQuestUI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

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
            questItemsListBox.Enabled = false;
            addReward.Enabled = false;
            removeReward.Enabled = false;
            rewardBehTexbox.Enabled = false;
            addObjective.Enabled = false;
            removeObjective.Enabled = false;
            objectivesListBox.Enabled = false;
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
    }
}
