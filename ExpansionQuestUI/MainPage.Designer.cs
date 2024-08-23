namespace ExpansionQuestUI
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idLabel = new Label();
            titleLabel = new Label();
            questTitleTextBox = new TextBox();
            descLabel1 = new Label();
            startDialogTextBox = new RichTextBox();
            againDialogTextBox = new RichTextBox();
            descLabel2 = new Label();
            endDialogTextBox = new RichTextBox();
            descLabel3 = new Label();
            objTextBox = new TextBox();
            objLabel = new Label();
            repeatable = new CheckBox();
            isDaily = new CheckBox();
            isWeekly = new CheckBox();
            cancelOnDeath = new CheckBox();
            autocomplete = new CheckBox();
            isGroup = new CheckBox();
            followUpQuestIdTextBox = new MaskedTextBox();
            followUpQuestLabel = new Label();
            mapFileNameTextBox = new TextBox();
            fileNameLabel = new Label();
            questItemsLabel = new Label();
            addQuestItem = new Button();
            deleteQuestItem = new Button();
            questItemsListBox = new ListBox();
            rewardsListbox = new ListBox();
            removeReward = new Button();
            addReward = new Button();
            rewardsLabel = new Label();
            selectReward = new CheckBox();
            randomReward = new CheckBox();
            rewardForOwner = new CheckBox();
            rewardBehTexbox = new MaskedTextBox();
            rewardBeh = new Label();
            giverNPCTextBox = new MaskedTextBox();
            giverNPCLabel = new Label();
            turninNPCIDTexBox = new MaskedTextBox();
            tunrinNPCIDLabel = new Label();
            achievment = new CheckBox();
            addObjective = new Button();
            removeObjective = new Button();
            objectiveLabel = new Label();
            objectivesListBox = new ListBox();
            colorIdTextBox = new MaskedTextBox();
            colorLabel = new Label();
            repQuestTextBox = new MaskedTextBox();
            repLabel = new Label();
            repNeedQuestTextBox = new MaskedTextBox();
            repNeedLabel = new Label();
            prevQuestTextBox = new MaskedTextBox();
            prevQuestLabe = new Label();
            needQuestItems = new CheckBox();
            deleteQuestItems = new CheckBox();
            seqQuest = new CheckBox();
            idTextBox = new TextBox();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(57, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID Квеста";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 60);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(97, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Название квеста";
            // 
            // questTitleTextBox
            // 
            questTitleTextBox.Location = new Point(126, 57);
            questTitleTextBox.Name = "questTitleTextBox";
            questTitleTextBox.Size = new Size(314, 23);
            questTitleTextBox.TabIndex = 4;
            // 
            // descLabel1
            // 
            descLabel1.AutoSize = true;
            descLabel1.Location = new Point(12, 94);
            descLabel1.Name = "descLabel1";
            descLabel1.Size = new Size(108, 15);
            descLabel1.TabIndex = 5;
            descLabel1.Text = "Стартовый диалог";
            // 
            // startDialogTextBox
            // 
            startDialogTextBox.Location = new Point(126, 91);
            startDialogTextBox.Name = "startDialogTextBox";
            startDialogTextBox.Size = new Size(314, 96);
            startDialogTextBox.TabIndex = 7;
            startDialogTextBox.Text = "";
            // 
            // againDialogTextBox
            // 
            againDialogTextBox.Location = new Point(126, 193);
            againDialogTextBox.Name = "againDialogTextBox";
            againDialogTextBox.Size = new Size(314, 96);
            againDialogTextBox.TabIndex = 9;
            againDialogTextBox.Text = "";
            // 
            // descLabel2
            // 
            descLabel2.AutoSize = true;
            descLabel2.Location = new Point(12, 196);
            descLabel2.Name = "descLabel2";
            descLabel2.Size = new Size(112, 15);
            descLabel2.TabIndex = 8;
            descLabel2.Text = "Повторный диалог";
            // 
            // endDialogTextBox
            // 
            endDialogTextBox.Location = new Point(126, 295);
            endDialogTextBox.Name = "endDialogTextBox";
            endDialogTextBox.Size = new Size(314, 96);
            endDialogTextBox.TabIndex = 11;
            endDialogTextBox.Text = "";
            // 
            // descLabel3
            // 
            descLabel3.AutoSize = true;
            descLabel3.Location = new Point(12, 298);
            descLabel3.Name = "descLabel3";
            descLabel3.Size = new Size(112, 15);
            descLabel3.TabIndex = 10;
            descLabel3.Text = "Финишный диалог";
            // 
            // objTextBox
            // 
            objTextBox.Location = new Point(126, 397);
            objTextBox.Name = "objTextBox";
            objTextBox.Size = new Size(314, 23);
            objTextBox.TabIndex = 13;
            // 
            // objLabel
            // 
            objLabel.AutoSize = true;
            objLabel.Location = new Point(12, 400);
            objLabel.Name = "objLabel";
            objLabel.Size = new Size(104, 15);
            objLabel.TabIndex = 12;
            objLabel.Text = "Текст цели квеста";
            // 
            // repeatable
            // 
            repeatable.AutoSize = true;
            repeatable.Location = new Point(14, 427);
            repeatable.Name = "repeatable";
            repeatable.Size = new Size(104, 19);
            repeatable.TabIndex = 14;
            repeatable.Text = "Повторяемый";
            repeatable.UseVisualStyleBackColor = true;
            // 
            // isDaily
            // 
            isDaily.AutoSize = true;
            isDaily.Location = new Point(124, 427);
            isDaily.Name = "isDaily";
            isDaily.Size = new Size(95, 19);
            isDaily.TabIndex = 15;
            isDaily.Text = "Ежедневный";
            isDaily.UseVisualStyleBackColor = true;
            // 
            // isWeekly
            // 
            isWeekly.AutoSize = true;
            isWeekly.Location = new Point(225, 427);
            isWeekly.Name = "isWeekly";
            isWeekly.Size = new Size(108, 19);
            isWeekly.TabIndex = 16;
            isWeekly.Text = "Еженедельный";
            isWeekly.UseVisualStyleBackColor = true;
            // 
            // cancelOnDeath
            // 
            cancelOnDeath.AutoSize = true;
            cancelOnDeath.Location = new Point(14, 452);
            cancelOnDeath.Name = "cancelOnDeath";
            cancelOnDeath.Size = new Size(179, 19);
            cancelOnDeath.TabIndex = 19;
            cancelOnDeath.Text = "Отменить квест при смерти";
            cancelOnDeath.UseVisualStyleBackColor = true;
            // 
            // autocomplete
            // 
            autocomplete.AutoSize = true;
            autocomplete.Location = new Point(199, 452);
            autocomplete.Name = "autocomplete";
            autocomplete.Size = new Size(121, 19);
            autocomplete.TabIndex = 18;
            autocomplete.Text = "Автовыполнение";
            autocomplete.UseVisualStyleBackColor = true;
            // 
            // isGroup
            // 
            isGroup.AutoSize = true;
            isGroup.Location = new Point(326, 452);
            isGroup.Name = "isGroup";
            isGroup.Size = new Size(118, 19);
            isGroup.TabIndex = 17;
            isGroup.Text = "Групповой квест";
            isGroup.UseVisualStyleBackColor = true;
            // 
            // followUpQuestIdTextBox
            // 
            followUpQuestIdTextBox.Location = new Point(279, 560);
            followUpQuestIdTextBox.Name = "followUpQuestIdTextBox";
            followUpQuestIdTextBox.Size = new Size(54, 23);
            followUpQuestIdTextBox.TabIndex = 21;
            followUpQuestIdTextBox.KeyPress += followUpQuestIdTextBox_KeyPress;
            // 
            // followUpQuestLabel
            // 
            followUpQuestLabel.AutoSize = true;
            followUpQuestLabel.Location = new Point(12, 563);
            followUpQuestLabel.Name = "followUpQuestLabel";
            followUpQuestLabel.Size = new Size(131, 15);
            followUpQuestLabel.TabIndex = 20;
            followUpQuestLabel.Text = "ID Следующего квеста";
            // 
            // mapFileNameTextBox
            // 
            mapFileNameTextBox.Location = new Point(615, 31);
            mapFileNameTextBox.Name = "mapFileNameTextBox";
            mapFileNameTextBox.Size = new Size(314, 23);
            mapFileNameTextBox.TabIndex = 23;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(482, 34);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(127, 15);
            fileNameLabel.TabIndex = 22;
            fileNameLabel.Text = "Название .map файла";
            // 
            // questItemsLabel
            // 
            questItemsLabel.AutoSize = true;
            questItemsLabel.Location = new Point(483, 76);
            questItemsLabel.Name = "questItemsLabel";
            questItemsLabel.Size = new Size(123, 15);
            questItemsLabel.TabIndex = 24;
            questItemsLabel.Text = "Квестовые предметы";
            // 
            // addQuestItem
            // 
            addQuestItem.Location = new Point(612, 72);
            addQuestItem.Name = "addQuestItem";
            addQuestItem.Size = new Size(75, 23);
            addQuestItem.TabIndex = 25;
            addQuestItem.Text = "Добавить";
            addQuestItem.UseVisualStyleBackColor = true;
            // 
            // deleteQuestItem
            // 
            deleteQuestItem.Location = new Point(693, 72);
            deleteQuestItem.Name = "deleteQuestItem";
            deleteQuestItem.Size = new Size(75, 23);
            deleteQuestItem.TabIndex = 26;
            deleteQuestItem.Text = "Удалить";
            deleteQuestItem.UseVisualStyleBackColor = true;
            // 
            // questItemsListBox
            // 
            questItemsListBox.FormattingEnabled = true;
            questItemsListBox.ItemHeight = 15;
            questItemsListBox.Location = new Point(482, 104);
            questItemsListBox.Name = "questItemsListBox";
            questItemsListBox.Size = new Size(444, 124);
            questItemsListBox.TabIndex = 27;
            // 
            // rewardsListbox
            // 
            rewardsListbox.FormattingEnabled = true;
            rewardsListbox.ItemHeight = 15;
            rewardsListbox.Location = new Point(482, 266);
            rewardsListbox.Name = "rewardsListbox";
            rewardsListbox.Size = new Size(444, 154);
            rewardsListbox.TabIndex = 31;
            // 
            // removeReward
            // 
            removeReward.Location = new Point(693, 234);
            removeReward.Name = "removeReward";
            removeReward.Size = new Size(75, 23);
            removeReward.TabIndex = 30;
            removeReward.Text = "Удалить";
            removeReward.UseVisualStyleBackColor = true;
            // 
            // addReward
            // 
            addReward.Location = new Point(612, 234);
            addReward.Name = "addReward";
            addReward.Size = new Size(75, 23);
            addReward.TabIndex = 29;
            addReward.Text = "Добавить";
            addReward.UseVisualStyleBackColor = true;
            // 
            // rewardsLabel
            // 
            rewardsLabel.AutoSize = true;
            rewardsLabel.Location = new Point(482, 238);
            rewardsLabel.Name = "rewardsLabel";
            rewardsLabel.Size = new Size(55, 15);
            rewardsLabel.TabIndex = 28;
            rewardsLabel.Text = "Награды";
            // 
            // selectReward
            // 
            selectReward.AutoSize = true;
            selectReward.Location = new Point(14, 477);
            selectReward.Name = "selectReward";
            selectReward.Size = new Size(192, 19);
            selectReward.TabIndex = 32;
            selectReward.Text = "Необходимо выбрать награду";
            selectReward.UseVisualStyleBackColor = true;
            // 
            // randomReward
            // 
            randomReward.AutoSize = true;
            randomReward.Location = new Point(212, 477);
            randomReward.Name = "randomReward";
            randomReward.Size = new Size(132, 19);
            randomReward.TabIndex = 33;
            randomReward.Text = "Случайная награда";
            randomReward.UseVisualStyleBackColor = true;
            // 
            // rewardForOwner
            // 
            rewardForOwner.AutoSize = true;
            rewardForOwner.Location = new Point(14, 502);
            rewardForOwner.Name = "rewardForOwner";
            rewardForOwner.Size = new Size(220, 19);
            rewardForOwner.TabIndex = 34;
            rewardForOwner.Text = "Награда только для лидера группы";
            rewardForOwner.UseVisualStyleBackColor = true;
            // 
            // rewardBehTexbox
            // 
            rewardBehTexbox.Location = new Point(279, 589);
            rewardBehTexbox.Name = "rewardBehTexbox";
            rewardBehTexbox.Size = new Size(54, 23);
            rewardBehTexbox.TabIndex = 36;
            rewardBehTexbox.KeyPress += rewardBehTexbox_KeyPress;
            // 
            // rewardBeh
            // 
            rewardBeh.AutoSize = true;
            rewardBeh.Location = new Point(12, 592);
            rewardBeh.Name = "rewardBeh";
            rewardBeh.Size = new Size(237, 15);
            rewardBeh.TabIndex = 35;
            rewardBeh.Text = "Поведение награды(не знаешь не трогай)";
            // 
            // giverNPCTextBox
            // 
            giverNPCTextBox.Location = new Point(279, 618);
            giverNPCTextBox.Name = "giverNPCTextBox";
            giverNPCTextBox.Size = new Size(54, 23);
            giverNPCTextBox.TabIndex = 38;
            giverNPCTextBox.KeyPress += giverNPCTextBox_KeyPress;
            // 
            // giverNPCLabel
            // 
            giverNPCLabel.AutoSize = true;
            giverNPCLabel.Location = new Point(12, 621);
            giverNPCLabel.Name = "giverNPCLabel";
            giverNPCLabel.Size = new Size(234, 15);
            giverNPCLabel.TabIndex = 37;
            giverNPCLabel.Text = "ID NPC Выдающего квест(через запятую)";
            // 
            // turninNPCIDTexBox
            // 
            turninNPCIDTexBox.Location = new Point(279, 647);
            turninNPCIDTexBox.Name = "turninNPCIDTexBox";
            turninNPCIDTexBox.Size = new Size(54, 23);
            turninNPCIDTexBox.TabIndex = 40;
            turninNPCIDTexBox.KeyPress += turninNPCIDTexBox_KeyPress;
            // 
            // tunrinNPCIDLabel
            // 
            tunrinNPCIDLabel.AutoSize = true;
            tunrinNPCIDLabel.Location = new Point(12, 650);
            tunrinNPCIDLabel.Name = "tunrinNPCIDLabel";
            tunrinNPCIDLabel.Size = new Size(258, 15);
            tunrinNPCIDLabel.TabIndex = 39;
            tunrinNPCIDLabel.Text = "ID NPC Принимающего квест(через запятую)";
            // 
            // achievment
            // 
            achievment.AutoSize = true;
            achievment.Location = new Point(240, 502);
            achievment.Name = "achievment";
            achievment.Size = new Size(66, 19);
            achievment.TabIndex = 41;
            achievment.Text = "Ачивка";
            achievment.UseVisualStyleBackColor = true;
            // 
            // addObjective
            // 
            addObjective.Location = new Point(612, 433);
            addObjective.Name = "addObjective";
            addObjective.Size = new Size(75, 23);
            addObjective.TabIndex = 42;
            addObjective.Text = "Добавить";
            addObjective.UseVisualStyleBackColor = true;
            // 
            // removeObjective
            // 
            removeObjective.Location = new Point(693, 433);
            removeObjective.Name = "removeObjective";
            removeObjective.Size = new Size(75, 23);
            removeObjective.TabIndex = 43;
            removeObjective.Text = "Удалить";
            removeObjective.UseVisualStyleBackColor = true;
            // 
            // objectiveLabel
            // 
            objectiveLabel.AutoSize = true;
            objectiveLabel.Location = new Point(482, 437);
            objectiveLabel.Name = "objectiveLabel";
            objectiveLabel.Size = new Size(84, 15);
            objectiveLabel.TabIndex = 44;
            objectiveLabel.Text = "Задачи квеста";
            // 
            // objectivesListBox
            // 
            objectivesListBox.FormattingEnabled = true;
            objectivesListBox.ItemHeight = 15;
            objectivesListBox.Location = new Point(482, 462);
            objectivesListBox.Name = "objectivesListBox";
            objectivesListBox.Size = new Size(444, 154);
            objectivesListBox.TabIndex = 45;
            // 
            // colorIdTextBox
            // 
            colorIdTextBox.Location = new Point(279, 676);
            colorIdTextBox.Name = "colorIdTextBox";
            colorIdTextBox.Size = new Size(54, 23);
            colorIdTextBox.TabIndex = 47;
            colorIdTextBox.KeyPress += colorIdTextBox_KeyPress;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(12, 679);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(51, 15);
            colorLabel.TabIndex = 46;
            colorLabel.Text = "ID цвета";
            // 
            // repQuestTextBox
            // 
            repQuestTextBox.Location = new Point(279, 705);
            repQuestTextBox.Name = "repQuestTextBox";
            repQuestTextBox.Size = new Size(54, 23);
            repQuestTextBox.TabIndex = 49;
            repQuestTextBox.KeyPress += repQuestTextBox_KeyPress;
            // 
            // repLabel
            // 
            repLabel.AutoSize = true;
            repLabel.Location = new Point(12, 708);
            repLabel.Name = "repLabel";
            repLabel.Size = new Size(189, 15);
            repLabel.TabIndex = 48;
            repLabel.Text = "Кол-во очков репутации за квест";
            // 
            // repNeedQuestTextBox
            // 
            repNeedQuestTextBox.Location = new Point(279, 734);
            repNeedQuestTextBox.Name = "repNeedQuestTextBox";
            repNeedQuestTextBox.Size = new Size(54, 23);
            repNeedQuestTextBox.TabIndex = 51;
            repNeedQuestTextBox.KeyPress += repNeedQuestTextBox_KeyPress;
            // 
            // repNeedLabel
            // 
            repNeedLabel.AutoSize = true;
            repNeedLabel.Location = new Point(12, 737);
            repNeedLabel.Name = "repNeedLabel";
            repNeedLabel.Size = new Size(203, 15);
            repNeedLabel.TabIndex = 50;
            repNeedLabel.Text = "Кол-во очков репутации для квеста";
            // 
            // prevQuestTextBox
            // 
            prevQuestTextBox.Location = new Point(279, 763);
            prevQuestTextBox.Name = "prevQuestTextBox";
            prevQuestTextBox.Size = new Size(54, 23);
            prevQuestTextBox.TabIndex = 53;
            prevQuestTextBox.KeyPress += prevQuestTextBox_KeyPress;
            // 
            // prevQuestLabe
            // 
            prevQuestLabe.AutoSize = true;
            prevQuestLabe.Location = new Point(12, 766);
            prevQuestLabe.Name = "prevQuestLabe";
            prevQuestLabe.Size = new Size(214, 15);
            prevQuestLabe.TabIndex = 52;
            prevQuestLabe.Text = "Необходимые квесты(через запятую)";
            // 
            // needQuestItems
            // 
            needQuestItems.AutoSize = true;
            needQuestItems.Location = new Point(14, 527);
            needQuestItems.Name = "needQuestItems";
            needQuestItems.Size = new Size(217, 19);
            needQuestItems.TabIndex = 54;
            needQuestItems.Text = "Необходимы квестовые предметы";
            needQuestItems.UseVisualStyleBackColor = true;
            // 
            // deleteQuestItems
            // 
            deleteQuestItems.AutoSize = true;
            deleteQuestItems.Location = new Point(237, 527);
            deleteQuestItems.Name = "deleteQuestItems";
            deleteQuestItems.Size = new Size(187, 19);
            deleteQuestItems.TabIndex = 55;
            deleteQuestItems.Text = "Удалять квестовые предметы";
            deleteQuestItems.UseVisualStyleBackColor = true;
            // 
            // seqQuest
            // 
            seqQuest.AutoSize = true;
            seqQuest.Location = new Point(312, 502);
            seqQuest.Name = "seqQuest";
            seqQuest.Size = new Size(131, 19);
            seqQuest.TabIndex = 56;
            seqQuest.Text = "Очередность задач";
            seqQuest.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(126, 26);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(53, 23);
            idTextBox.TabIndex = 57;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 866);
            Controls.Add(idTextBox);
            Controls.Add(seqQuest);
            Controls.Add(deleteQuestItems);
            Controls.Add(needQuestItems);
            Controls.Add(prevQuestTextBox);
            Controls.Add(prevQuestLabe);
            Controls.Add(repNeedQuestTextBox);
            Controls.Add(repNeedLabel);
            Controls.Add(repQuestTextBox);
            Controls.Add(repLabel);
            Controls.Add(colorIdTextBox);
            Controls.Add(colorLabel);
            Controls.Add(objectivesListBox);
            Controls.Add(objectiveLabel);
            Controls.Add(removeObjective);
            Controls.Add(addObjective);
            Controls.Add(achievment);
            Controls.Add(turninNPCIDTexBox);
            Controls.Add(tunrinNPCIDLabel);
            Controls.Add(giverNPCTextBox);
            Controls.Add(giverNPCLabel);
            Controls.Add(rewardBehTexbox);
            Controls.Add(rewardBeh);
            Controls.Add(rewardForOwner);
            Controls.Add(randomReward);
            Controls.Add(selectReward);
            Controls.Add(rewardsListbox);
            Controls.Add(removeReward);
            Controls.Add(addReward);
            Controls.Add(rewardsLabel);
            Controls.Add(questItemsListBox);
            Controls.Add(deleteQuestItem);
            Controls.Add(addQuestItem);
            Controls.Add(questItemsLabel);
            Controls.Add(mapFileNameTextBox);
            Controls.Add(fileNameLabel);
            Controls.Add(followUpQuestIdTextBox);
            Controls.Add(followUpQuestLabel);
            Controls.Add(cancelOnDeath);
            Controls.Add(autocomplete);
            Controls.Add(isGroup);
            Controls.Add(isWeekly);
            Controls.Add(isDaily);
            Controls.Add(repeatable);
            Controls.Add(objTextBox);
            Controls.Add(objLabel);
            Controls.Add(endDialogTextBox);
            Controls.Add(descLabel3);
            Controls.Add(againDialogTextBox);
            Controls.Add(descLabel2);
            Controls.Add(startDialogTextBox);
            Controls.Add(descLabel1);
            Controls.Add(questTitleTextBox);
            Controls.Add(titleLabel);
            Controls.Add(idLabel);
            Name = "MainPage";
            Text = "Редактор квестов by fkn_goose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label idLabel;
        private Label titleLabel;
        private TextBox questTitleTextBox;
        private Label descLabel1;
        private RichTextBox startDialogTextBox;
        private RichTextBox againDialogTextBox;
        private Label descLabel2;
        private RichTextBox endDialogTextBox;
        private Label descLabel3;
        private TextBox objTextBox;
        private Label objLabel;
        private CheckBox repeatable;
        private CheckBox isDaily;
        private CheckBox isWeekly;
        private CheckBox cancelOnDeath;
        private CheckBox autocomplete;
        private CheckBox isGroup;
        private MaskedTextBox followUpQuestIdTextBox;
        private Label followUpQuestLabel;
        private TextBox mapFileNameTextBox;
        private Label fileNameLabel;
        private Label questItemsLabel;
        private Button addQuestItem;
        private Button deleteQuestItem;
        private ListBox questItemsListBox;
        private ListBox rewardsListbox;
        private Button removeReward;
        private Button addReward;
        private Label rewardsLabel;
        private CheckBox selectReward;
        private CheckBox randomReward;
        private CheckBox rewardForOwner;
        private MaskedTextBox rewardBehTexbox;
        private Label rewardBeh;
        private MaskedTextBox giverNPCTextBox;
        private Label giverNPCLabel;
        private MaskedTextBox turninNPCIDTexBox;
        private Label tunrinNPCIDLabel;
        private CheckBox achievment;
        private Button addObjective;
        private Button removeObjective;
        private Label objectiveLabel;
        private ListBox objectivesListBox;
        private MaskedTextBox colorIdTextBox;
        private Label colorLabel;
        private MaskedTextBox repQuestTextBox;
        private Label repLabel;
        private MaskedTextBox repNeedQuestTextBox;
        private Label repNeedLabel;
        private MaskedTextBox prevQuestTextBox;
        private Label prevQuestLabe;
        private CheckBox needQuestItems;
        private CheckBox deleteQuestItems;
        private CheckBox seqQuest;
        private TextBox idTextBox;
    }
}
