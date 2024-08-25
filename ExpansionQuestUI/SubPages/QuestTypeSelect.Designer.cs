namespace ExpansionQuestUI.SubPages
{
    partial class QuestTypeSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            selectTraget = new Button();
            selectTravel = new Button();
            selectCollect = new Button();
            selectDelivery = new Button();
            selectTreasure = new Button();
            selectPatrol = new Button();
            selectCamp = new Button();
            selectVIP = new Button();
            selectAction = new Button();
            selectCrafting = new Button();
            addOwn = new Button();
            close = new Button();
            objectiveTypeTextBox = new TextBox();
            idTextBox = new TextBox();
            objectiveTypeLabel = new Label();
            idLabel = new Label();
            SuspendLayout();
            // 
            // selectTraget
            // 
            selectTraget.Location = new Point(12, 12);
            selectTraget.Name = "selectTraget";
            selectTraget.Size = new Size(178, 23);
            selectTraget.TabIndex = 0;
            selectTraget.Text = "Target/Устранить цель";
            selectTraget.UseVisualStyleBackColor = true;
            selectTraget.Click += selectTraget_Click;
            // 
            // selectTravel
            // 
            selectTravel.Location = new Point(12, 41);
            selectTravel.Name = "selectTravel";
            selectTravel.Size = new Size(178, 23);
            selectTravel.TabIndex = 1;
            selectTravel.Text = "Travel/Добраться до точки";
            selectTravel.UseVisualStyleBackColor = true;
            selectTravel.Click += selectTravel_Click;
            // 
            // selectCollect
            // 
            selectCollect.Location = new Point(12, 70);
            selectCollect.Name = "selectCollect";
            selectCollect.Size = new Size(178, 23);
            selectCollect.TabIndex = 2;
            selectCollect.Text = "Collect/Сбор";
            selectCollect.UseVisualStyleBackColor = true;
            selectCollect.Click += selectCollect_Click;
            // 
            // selectDelivery
            // 
            selectDelivery.Location = new Point(12, 99);
            selectDelivery.Name = "selectDelivery";
            selectDelivery.Size = new Size(178, 23);
            selectDelivery.TabIndex = 3;
            selectDelivery.Text = "Delivery/Доставка";
            selectDelivery.UseVisualStyleBackColor = true;
            selectDelivery.Click += selectDelivery_Click;
            // 
            // selectTreasure
            // 
            selectTreasure.Location = new Point(12, 128);
            selectTreasure.Name = "selectTreasure";
            selectTreasure.Size = new Size(178, 23);
            selectTreasure.TabIndex = 4;
            selectTreasure.Text = "Treasurehunt/Тайник";
            selectTreasure.UseVisualStyleBackColor = true;
            selectTreasure.Click += selectTreasure_Click;
            // 
            // selectPatrol
            // 
            selectPatrol.Enabled = false;
            selectPatrol.Location = new Point(12, 157);
            selectPatrol.Name = "selectPatrol";
            selectPatrol.Size = new Size(178, 23);
            selectPatrol.TabIndex = 5;
            selectPatrol.Text = "AIPatrol/Патруль";
            selectPatrol.UseVisualStyleBackColor = true;
            // 
            // selectCamp
            // 
            selectCamp.Enabled = false;
            selectCamp.Location = new Point(12, 186);
            selectCamp.Name = "selectCamp";
            selectCamp.Size = new Size(178, 23);
            selectCamp.TabIndex = 6;
            selectCamp.Text = "AICamp/Зачистка лагеря";
            selectCamp.UseVisualStyleBackColor = true;
            // 
            // selectVIP
            // 
            selectVIP.Enabled = false;
            selectVIP.Location = new Point(12, 215);
            selectVIP.Name = "selectVIP";
            selectVIP.Size = new Size(178, 23);
            selectVIP.TabIndex = 7;
            selectVIP.Text = "AIVip/Сопровождение";
            selectVIP.UseVisualStyleBackColor = true;
            // 
            // selectAction
            // 
            selectAction.Enabled = false;
            selectAction.Location = new Point(12, 244);
            selectAction.Name = "selectAction";
            selectAction.Size = new Size(178, 23);
            selectAction.TabIndex = 8;
            selectAction.Text = "Action/Действие";
            selectAction.UseVisualStyleBackColor = true;
            // 
            // selectCrafting
            // 
            selectCrafting.Enabled = false;
            selectCrafting.Location = new Point(12, 273);
            selectCrafting.Name = "selectCrafting";
            selectCrafting.Size = new Size(178, 23);
            selectCrafting.TabIndex = 9;
            selectCrafting.Text = "Crafting/Крафт";
            selectCrafting.UseVisualStyleBackColor = true;
            // 
            // addOwn
            // 
            addOwn.Location = new Point(12, 359);
            addOwn.Name = "addOwn";
            addOwn.Size = new Size(178, 23);
            addOwn.TabIndex = 10;
            addOwn.Text = "Добавить без создания";
            addOwn.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            close.Location = new Point(12, 388);
            close.Name = "close";
            close.Size = new Size(178, 23);
            close.TabIndex = 11;
            close.Text = "Закрыть";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // objectiveTypeTextBox
            // 
            objectiveTypeTextBox.Location = new Point(99, 330);
            objectiveTypeTextBox.Name = "objectiveTypeTextBox";
            objectiveTypeTextBox.Size = new Size(91, 23);
            objectiveTypeTextBox.TabIndex = 12;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(99, 301);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(91, 23);
            idTextBox.TabIndex = 13;
            // 
            // objectiveTypeLabel
            // 
            objectiveTypeLabel.AutoSize = true;
            objectiveTypeLabel.Location = new Point(12, 333);
            objectiveTypeLabel.Name = "objectiveTypeLabel";
            objectiveTypeLabel.Size = new Size(81, 15);
            objectiveTypeLabel.TabIndex = 14;
            objectiveTypeLabel.Text = "ObjectiveType";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 304);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 15;
            idLabel.Text = "ID";
            // 
            // QuestTypeSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 418);
            Controls.Add(idLabel);
            Controls.Add(objectiveTypeLabel);
            Controls.Add(idTextBox);
            Controls.Add(objectiveTypeTextBox);
            Controls.Add(close);
            Controls.Add(addOwn);
            Controls.Add(selectCrafting);
            Controls.Add(selectAction);
            Controls.Add(selectVIP);
            Controls.Add(selectCamp);
            Controls.Add(selectPatrol);
            Controls.Add(selectTreasure);
            Controls.Add(selectDelivery);
            Controls.Add(selectCollect);
            Controls.Add(selectTravel);
            Controls.Add(selectTraget);
            Name = "QuestTypeSelect";
            Text = "Создать задачу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectTraget;
        private Button selectTravel;
        private Button selectCollect;
        private Button selectDelivery;
        private Button selectTreasure;
        private Button selectPatrol;
        private Button selectCamp;
        private Button selectVIP;
        private Button selectAction;
        private Button selectCrafting;
        private Button addOwn;
        private Button close;
        private TextBox objectiveTypeTextBox;
        private TextBox idTextBox;
        private Label objectiveTypeLabel;
        private Label idLabel;
    }
}