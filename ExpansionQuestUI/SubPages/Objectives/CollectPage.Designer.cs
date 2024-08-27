namespace ExpansionQuestUI.SubPages.Objectives
{
    partial class CollectPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectPage));
            textLabel = new Label();
            timeLimitLabel = new Label();
            idLabel = new Label();
            textTextBox = new TextBox();
            timeLimitTextBox = new TextBox();
            idTextBox = new TextBox();
            itemsData = new DataGridView();
            Amount = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            QuantityPercent = new DataGridViewTextBoxColumn();
            MinQuantityPercent = new DataGridViewTextBoxColumn();
            deleteItem = new Button();
            addItem = new Button();
            questItemsLabel = new Label();
            addZone = new CheckBox();
            showDistance = new CheckBox();
            needAny = new CheckBox();
            cancel = new Button();
            addTarget = new Button();
            filenameLabel = new Label();
            filenameTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)itemsData).BeginInit();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(10, 38);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(76, 15);
            textLabel.TabIndex = 37;
            textLabel.Text = "Текст задачи";
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.AutoSize = true;
            timeLimitLabel.Location = new Point(10, 67);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new Size(111, 15);
            timeLimitLabel.TabIndex = 36;
            timeLimitLabel.Text = "Лимит по времени";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 12);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 35;
            idLabel.Text = "ID";
            // 
            // textTextBox
            // 
            textTextBox.Location = new Point(168, 35);
            textTextBox.Name = "textTextBox";
            textTextBox.Size = new Size(176, 23);
            textTextBox.TabIndex = 34;
            // 
            // timeLimitTextBox
            // 
            timeLimitTextBox.Location = new Point(168, 64);
            timeLimitTextBox.Name = "timeLimitTextBox";
            timeLimitTextBox.Size = new Size(51, 23);
            timeLimitTextBox.TabIndex = 33;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(168, 9);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(51, 23);
            idTextBox.TabIndex = 32;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // itemsData
            // 
            itemsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsData.Columns.AddRange(new DataGridViewColumn[] { Amount, ClassName, QuantityPercent, MinQuantityPercent });
            itemsData.Location = new Point(10, 151);
            itemsData.Name = "itemsData";
            itemsData.Size = new Size(576, 212);
            itemsData.TabIndex = 38;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 76;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassName.HeaderText = "ClassName";
            ClassName.MinimumWidth = 150;
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            ClassName.Width = 200;
            // 
            // QuantityPercent
            // 
            QuantityPercent.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            QuantityPercent.HeaderText = "QuantityPercent";
            QuantityPercent.Name = "QuantityPercent";
            QuantityPercent.ReadOnly = true;
            QuantityPercent.Width = 118;
            // 
            // MinQuantityPercent
            // 
            MinQuantityPercent.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MinQuantityPercent.HeaderText = "MinQuantityPercent";
            MinQuantityPercent.Name = "MinQuantityPercent";
            MinQuantityPercent.ReadOnly = true;
            MinQuantityPercent.Width = 139;
            // 
            // deleteItem
            // 
            deleteItem.Location = new Point(242, 122);
            deleteItem.Name = "deleteItem";
            deleteItem.Size = new Size(75, 23);
            deleteItem.TabIndex = 41;
            deleteItem.Text = "Удалить";
            deleteItem.UseVisualStyleBackColor = true;
            deleteItem.Click += deleteItem_Click;
            // 
            // addItem
            // 
            addItem.Location = new Point(161, 122);
            addItem.Name = "addItem";
            addItem.Size = new Size(75, 23);
            addItem.TabIndex = 40;
            addItem.Text = "Добавить";
            addItem.UseVisualStyleBackColor = true;
            addItem.Click += addItem_Click;
            // 
            // questItemsLabel
            // 
            questItemsLabel.AutoSize = true;
            questItemsLabel.Location = new Point(11, 126);
            questItemsLabel.Name = "questItemsLabel";
            questItemsLabel.Size = new Size(144, 15);
            questItemsLabel.TabIndex = 39;
            questItemsLabel.Text = "Необходимые предметы";
            // 
            // addZone
            // 
            addZone.AutoSize = true;
            addZone.Location = new Point(369, 39);
            addZone.Name = "addZone";
            addZone.Size = new Size(215, 19);
            addZone.TabIndex = 42;
            addZone.Text = "Добавлять предметы в трейд-зону";
            addZone.UseVisualStyleBackColor = true;
            // 
            // showDistance
            // 
            showDistance.AutoSize = true;
            showDistance.Location = new Point(369, 13);
            showDistance.Name = "showDistance";
            showDistance.Size = new Size(157, 19);
            showDistance.TabIndex = 43;
            showDistance.Text = "Показывать расстояние";
            showDistance.UseVisualStyleBackColor = true;
            // 
            // needAny
            // 
            needAny.AutoSize = true;
            needAny.Location = new Point(369, 68);
            needAny.Name = "needAny";
            needAny.Size = new Size(170, 19);
            needAny.TabIndex = 44;
            needAny.Text = "Любой предмет из списка";
            needAny.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.Location = new Point(335, 378);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 46;
            cancel.Text = "Закрыть";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // addTarget
            // 
            addTarget.Location = new Point(170, 381);
            addTarget.Name = "addTarget";
            addTarget.Size = new Size(75, 23);
            addTarget.TabIndex = 45;
            addTarget.Text = "Добавить";
            addTarget.UseVisualStyleBackColor = true;
            addTarget.Click += addTarget_Click;
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(10, 96);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(97, 15);
            filenameLabel.TabIndex = 49;
            filenameLabel.Text = "Название файла";
            // 
            // filenameTextbox
            // 
            filenameTextbox.Location = new Point(168, 93);
            filenameTextbox.Name = "filenameTextbox";
            filenameTextbox.Size = new Size(100, 23);
            filenameTextbox.TabIndex = 48;
            // 
            // CollectPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 407);
            Controls.Add(filenameLabel);
            Controls.Add(filenameTextbox);
            Controls.Add(cancel);
            Controls.Add(addTarget);
            Controls.Add(needAny);
            Controls.Add(showDistance);
            Controls.Add(addZone);
            Controls.Add(deleteItem);
            Controls.Add(addItem);
            Controls.Add(questItemsLabel);
            Controls.Add(itemsData);
            Controls.Add(textLabel);
            Controls.Add(timeLimitLabel);
            Controls.Add(idLabel);
            Controls.Add(textTextBox);
            Controls.Add(timeLimitTextBox);
            Controls.Add(idTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CollectPage";
            Text = "CollectPage";
            ((System.ComponentModel.ISupportInitialize)itemsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private Label timeLimitLabel;
        private Label idLabel;
        private TextBox textTextBox;
        private TextBox timeLimitTextBox;
        private TextBox idTextBox;
        private DataGridView itemsData;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn QuantityPercent;
        private DataGridViewTextBoxColumn MinQuantityPercent;
        private Button deleteItem;
        private Button addItem;
        private Label questItemsLabel;
        private CheckBox addZone;
        private CheckBox showDistance;
        private CheckBox needAny;
        private Button cancel;
        private Button addTarget;
        private Label filenameLabel;
        private TextBox filenameTextbox;
    }
}