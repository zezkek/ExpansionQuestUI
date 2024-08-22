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
            idTextBox = new MaskedTextBox();
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
            Repeatable = new CheckBox();
            isDaily = new CheckBox();
            IsWeekly = new CheckBox();
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
            SelectReward = new CheckBox();
            randomReward = new CheckBox();
            rewardForOwner = new CheckBox();
            maskedTextBox1 = new MaskedTextBox();
            rewardBeh = new Label();
            giverNPCTextBox = new MaskedTextBox();
            giverNPCLabel = new Label();
            turninNPCIDTexBox = new MaskedTextBox();
            tunrinNPCIDLabel = new Label();
            achievment = new CheckBox();
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
            // idTextBox
            // 
            idTextBox.Location = new Point(126, 28);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(54, 23);
            idTextBox.TabIndex = 2;
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
            // Repeatable
            // 
            Repeatable.AutoSize = true;
            Repeatable.Location = new Point(12, 461);
            Repeatable.Name = "Repeatable";
            Repeatable.Size = new Size(104, 19);
            Repeatable.TabIndex = 14;
            Repeatable.Text = "Повторяемый";
            Repeatable.UseVisualStyleBackColor = true;
            // 
            // isDaily
            // 
            isDaily.AutoSize = true;
            isDaily.Location = new Point(122, 461);
            isDaily.Name = "isDaily";
            isDaily.Size = new Size(95, 19);
            isDaily.TabIndex = 15;
            isDaily.Text = "Ежедневный";
            isDaily.UseVisualStyleBackColor = true;
            // 
            // IsWeekly
            // 
            IsWeekly.AutoSize = true;
            IsWeekly.Location = new Point(223, 461);
            IsWeekly.Name = "IsWeekly";
            IsWeekly.Size = new Size(108, 19);
            IsWeekly.TabIndex = 16;
            IsWeekly.Text = "Еженедельный";
            IsWeekly.UseVisualStyleBackColor = true;
            // 
            // cancelOnDeath
            // 
            cancelOnDeath.AutoSize = true;
            cancelOnDeath.Location = new Point(12, 486);
            cancelOnDeath.Name = "cancelOnDeath";
            cancelOnDeath.Size = new Size(179, 19);
            cancelOnDeath.TabIndex = 19;
            cancelOnDeath.Text = "Отменить квест при смерти";
            cancelOnDeath.UseVisualStyleBackColor = true;
            // 
            // autocomplete
            // 
            autocomplete.AutoSize = true;
            autocomplete.Location = new Point(197, 486);
            autocomplete.Name = "autocomplete";
            autocomplete.Size = new Size(121, 19);
            autocomplete.TabIndex = 18;
            autocomplete.Text = "Автовыполнение";
            autocomplete.UseVisualStyleBackColor = true;
            // 
            // isGroup
            // 
            isGroup.AutoSize = true;
            isGroup.Location = new Point(324, 486);
            isGroup.Name = "isGroup";
            isGroup.Size = new Size(118, 19);
            isGroup.TabIndex = 17;
            isGroup.Text = "Групповой квест";
            isGroup.UseVisualStyleBackColor = true;
            // 
            // followUpQuestIdTextBox
            // 
            followUpQuestIdTextBox.Location = new Point(149, 426);
            followUpQuestIdTextBox.Name = "followUpQuestIdTextBox";
            followUpQuestIdTextBox.Size = new Size(54, 23);
            followUpQuestIdTextBox.TabIndex = 21;
            // 
            // followUpQuestLabel
            // 
            followUpQuestLabel.AutoSize = true;
            followUpQuestLabel.Location = new Point(12, 429);
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
            // SelectReward
            // 
            SelectReward.AutoSize = true;
            SelectReward.Location = new Point(12, 511);
            SelectReward.Name = "SelectReward";
            SelectReward.Size = new Size(192, 19);
            SelectReward.TabIndex = 32;
            SelectReward.Text = "Необходимо выбрать награду";
            SelectReward.UseVisualStyleBackColor = true;
            // 
            // randomReward
            // 
            randomReward.AutoSize = true;
            randomReward.Location = new Point(210, 511);
            randomReward.Name = "randomReward";
            randomReward.Size = new Size(132, 19);
            randomReward.TabIndex = 33;
            randomReward.Text = "Случайная награда";
            randomReward.UseVisualStyleBackColor = true;
            // 
            // rewardForOwner
            // 
            rewardForOwner.AutoSize = true;
            rewardForOwner.Location = new Point(12, 536);
            rewardForOwner.Name = "rewardForOwner";
            rewardForOwner.Size = new Size(220, 19);
            rewardForOwner.TabIndex = 34;
            rewardForOwner.Text = "Награда только для лидера группы";
            rewardForOwner.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(255, 569);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(54, 23);
            maskedTextBox1.TabIndex = 36;
            // 
            // rewardBeh
            // 
            rewardBeh.AutoSize = true;
            rewardBeh.Location = new Point(12, 572);
            rewardBeh.Name = "rewardBeh";
            rewardBeh.Size = new Size(237, 15);
            rewardBeh.TabIndex = 35;
            rewardBeh.Text = "Поведение награды(не знаешь не трогай)";
            // 
            // giverNPCTextBox
            // 
            giverNPCTextBox.Location = new Point(660, 428);
            giverNPCTextBox.Name = "giverNPCTextBox";
            giverNPCTextBox.Size = new Size(54, 23);
            giverNPCTextBox.TabIndex = 38;
            // 
            // giverNPCLabel
            // 
            giverNPCLabel.AutoSize = true;
            giverNPCLabel.Location = new Point(483, 431);
            giverNPCLabel.Name = "giverNPCLabel";
            giverNPCLabel.Size = new Size(147, 15);
            giverNPCLabel.TabIndex = 37;
            giverNPCLabel.Text = "ID NPC Выдающего квест";
            // 
            // turninNPCIDTexBox
            // 
            turninNPCIDTexBox.Location = new Point(660, 457);
            turninNPCIDTexBox.Name = "turninNPCIDTexBox";
            turninNPCIDTexBox.Size = new Size(54, 23);
            turninNPCIDTexBox.TabIndex = 40;
            // 
            // tunrinNPCIDLabel
            // 
            tunrinNPCIDLabel.AutoSize = true;
            tunrinNPCIDLabel.Location = new Point(483, 460);
            tunrinNPCIDLabel.Name = "tunrinNPCIDLabel";
            tunrinNPCIDLabel.Size = new Size(171, 15);
            tunrinNPCIDLabel.TabIndex = 39;
            tunrinNPCIDLabel.Text = "ID NPC Принимающего квест";
            // 
            // achievment
            // 
            achievment.AutoSize = true;
            achievment.Location = new Point(238, 536);
            achievment.Name = "achievment";
            achievment.Size = new Size(66, 19);
            achievment.TabIndex = 41;
            achievment.Text = "Ачивка";
            achievment.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 866);
            Controls.Add(achievment);
            Controls.Add(turninNPCIDTexBox);
            Controls.Add(tunrinNPCIDLabel);
            Controls.Add(giverNPCTextBox);
            Controls.Add(giverNPCLabel);
            Controls.Add(maskedTextBox1);
            Controls.Add(rewardBeh);
            Controls.Add(rewardForOwner);
            Controls.Add(randomReward);
            Controls.Add(SelectReward);
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
            Controls.Add(IsWeekly);
            Controls.Add(isDaily);
            Controls.Add(Repeatable);
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
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Name = "MainPage";
            Text = "Редактор квестов by fkn_goose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label idLabel;
        private MaskedTextBox idTextBox;
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
        private CheckBox Repeatable;
        private CheckBox isDaily;
        private CheckBox IsWeekly;
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
        private CheckBox SelectReward;
        private CheckBox randomReward;
        private CheckBox rewardForOwner;
        private MaskedTextBox maskedTextBox1;
        private Label rewardBeh;
        private MaskedTextBox giverNPCTextBox;
        private Label giverNPCLabel;
        private MaskedTextBox turninNPCIDTexBox;
        private Label tunrinNPCIDLabel;
        private CheckBox achievment;
    }
}
