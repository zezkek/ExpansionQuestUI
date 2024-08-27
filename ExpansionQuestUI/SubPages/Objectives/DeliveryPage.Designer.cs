namespace ExpansionQuestUI.SubPages.Objectives
{
    partial class DeliveryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryPage));
            filenameLabel = new Label();
            filenameTextbox = new TextBox();
            cancel = new Button();
            addTarget = new Button();
            showDistance = new CheckBox();
            addZone = new CheckBox();
            deleteItem = new Button();
            addItem = new Button();
            questItemsLabel = new Label();
            itemsData = new DataGridView();
            Amount = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            QuantityPercent = new DataGridViewTextBoxColumn();
            MinQuantityPercent = new DataGridViewTextBoxColumn();
            textLabel = new Label();
            timeLimitLabel = new Label();
            idLabel = new Label();
            textTextBox = new TextBox();
            timeLimitTextBox = new TextBox();
            idTextBox = new TextBox();
            label1 = new Label();
            markerNameTextBox = new TextBox();
            label2 = new Label();
            maxDidstanceTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)itemsData).BeginInit();
            SuspendLayout();
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(12, 95);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(97, 15);
            filenameLabel.TabIndex = 66;
            filenameLabel.Text = "Название файла";
            // 
            // filenameTextbox
            // 
            filenameTextbox.Location = new Point(170, 92);
            filenameTextbox.Name = "filenameTextbox";
            filenameTextbox.Size = new Size(100, 23);
            filenameTextbox.TabIndex = 65;
            // 
            // cancel
            // 
            cancel.Location = new Point(335, 446);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 64;
            cancel.Text = "Закрыть";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // addTarget
            // 
            addTarget.Location = new Point(170, 449);
            addTarget.Name = "addTarget";
            addTarget.Size = new Size(75, 23);
            addTarget.TabIndex = 63;
            addTarget.Text = "Добавить";
            addTarget.UseVisualStyleBackColor = true;
            addTarget.Click += addTarget_Click;
            // 
            // showDistance
            // 
            showDistance.AutoSize = true;
            showDistance.Location = new Point(371, 12);
            showDistance.Name = "showDistance";
            showDistance.Size = new Size(157, 19);
            showDistance.TabIndex = 61;
            showDistance.Text = "Показывать расстояние";
            showDistance.UseVisualStyleBackColor = true;
            // 
            // addZone
            // 
            addZone.AutoSize = true;
            addZone.Location = new Point(371, 38);
            addZone.Name = "addZone";
            addZone.Size = new Size(215, 19);
            addZone.TabIndex = 60;
            addZone.Text = "Добавлять предметы в трейд-зону";
            addZone.UseVisualStyleBackColor = true;
            // 
            // deleteItem
            // 
            deleteItem.Location = new Point(242, 190);
            deleteItem.Name = "deleteItem";
            deleteItem.Size = new Size(75, 23);
            deleteItem.TabIndex = 59;
            deleteItem.Text = "Удалить";
            deleteItem.UseVisualStyleBackColor = true;
            deleteItem.Click += deleteItem_Click;
            // 
            // addItem
            // 
            addItem.Location = new Point(161, 190);
            addItem.Name = "addItem";
            addItem.Size = new Size(75, 23);
            addItem.TabIndex = 58;
            addItem.Text = "Добавить";
            addItem.UseVisualStyleBackColor = true;
            addItem.Click += addItem_Click;
            // 
            // questItemsLabel
            // 
            questItemsLabel.AutoSize = true;
            questItemsLabel.Location = new Point(11, 194);
            questItemsLabel.Name = "questItemsLabel";
            questItemsLabel.Size = new Size(144, 15);
            questItemsLabel.TabIndex = 57;
            questItemsLabel.Text = "Необходимые предметы";
            // 
            // itemsData
            // 
            itemsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsData.Columns.AddRange(new DataGridViewColumn[] { Amount, ClassName, QuantityPercent, MinQuantityPercent });
            itemsData.Location = new Point(10, 219);
            itemsData.Name = "itemsData";
            itemsData.Size = new Size(576, 212);
            itemsData.TabIndex = 56;
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
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(12, 37);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(76, 15);
            textLabel.TabIndex = 55;
            textLabel.Text = "Текст задачи";
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.AutoSize = true;
            timeLimitLabel.Location = new Point(12, 66);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new Size(111, 15);
            timeLimitLabel.TabIndex = 54;
            timeLimitLabel.Text = "Лимит по времени";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(14, 11);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 53;
            idLabel.Text = "ID";
            // 
            // textTextBox
            // 
            textTextBox.Location = new Point(170, 34);
            textTextBox.Name = "textTextBox";
            textTextBox.Size = new Size(176, 23);
            textTextBox.TabIndex = 52;
            // 
            // timeLimitTextBox
            // 
            timeLimitTextBox.Location = new Point(170, 63);
            timeLimitTextBox.Name = "timeLimitTextBox";
            timeLimitTextBox.Size = new Size(51, 23);
            timeLimitTextBox.TabIndex = 51;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(170, 8);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(51, 23);
            idTextBox.TabIndex = 50;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 68;
            label1.Text = "Название маркера";
            // 
            // markerNameTextBox
            // 
            markerNameTextBox.Location = new Point(170, 121);
            markerNameTextBox.Name = "markerNameTextBox";
            markerNameTextBox.Size = new Size(100, 23);
            markerNameTextBox.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 70;
            label2.Text = "Макс. дистанция";
            // 
            // maxDidstanceTextBox
            // 
            maxDidstanceTextBox.Location = new Point(170, 150);
            maxDidstanceTextBox.Name = "maxDidstanceTextBox";
            maxDidstanceTextBox.Size = new Size(100, 23);
            maxDidstanceTextBox.TabIndex = 69;
            maxDidstanceTextBox.KeyPress += textBox1_KeyPress;
            // 
            // DeliveryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 485);
            Controls.Add(label2);
            Controls.Add(maxDidstanceTextBox);
            Controls.Add(label1);
            Controls.Add(markerNameTextBox);
            Controls.Add(filenameLabel);
            Controls.Add(filenameTextbox);
            Controls.Add(cancel);
            Controls.Add(addTarget);
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
            Name = "DeliveryPage";
            Text = "DeliveryPage";
            ((System.ComponentModel.ISupportInitialize)itemsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label filenameLabel;
        private TextBox filenameTextbox;
        private Button cancel;
        private Button addTarget;
        private CheckBox showDistance;
        private CheckBox addZone;
        private Button deleteItem;
        private Button addItem;
        private Label questItemsLabel;
        private DataGridView itemsData;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn QuantityPercent;
        private DataGridViewTextBoxColumn MinQuantityPercent;
        private Label textLabel;
        private Label timeLimitLabel;
        private Label idLabel;
        private TextBox textTextBox;
        private TextBox timeLimitTextBox;
        private TextBox idTextBox;
        private Label label1;
        private TextBox markerNameTextBox;
        private Label label2;
        private TextBox maxDidstanceTextBox;
    }
}