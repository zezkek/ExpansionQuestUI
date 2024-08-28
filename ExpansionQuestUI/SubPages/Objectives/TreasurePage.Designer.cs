namespace ExpansionQuestUI.SubPages.Objectives
{
    partial class TreasurePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreasurePage));
            textLabel = new Label();
            timeLimitLabel = new Label();
            idLabel = new Label();
            textTextBox = new TextBox();
            timeLimitTextBox = new TextBox();
            idTextBox = new TextBox();
            showDistance = new CheckBox();
            contClassname = new ComboBox();
            label1 = new Label();
            digIn = new CheckBox();
            label2 = new Label();
            markerNameTextBox = new TextBox();
            label3 = new Label();
            markerVis = new ComboBox();
            coordinatesData = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            z = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            itemsAmount = new TextBox();
            label6 = new Label();
            maxDidstanceTextBox = new TextBox();
            cancel = new Button();
            addTarget = new Button();
            treasureData = new DataGridView();
            ClassName = new DataGridViewTextBoxColumn();
            Chance = new DataGridViewTextBoxColumn();
            Attachments = new DataGridViewTextBoxColumn();
            QuantityPercent = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Variants = new DataGridViewTextBoxColumn();
            filenameLabel = new Label();
            filenameTextbox = new TextBox();
            addLoot = new Button();
            removeLoot = new Button();
            label7 = new Label();
            xlabel = new Label();
            coordsTextBox = new TextBox();
            removeCoords = new Button();
            addCoords = new Button();
            ((System.ComponentModel.ISupportInitialize)coordinatesData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)treasureData).BeginInit();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(11, 39);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(76, 15);
            textLabel.TabIndex = 37;
            textLabel.Text = "Текст задачи";
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.AutoSize = true;
            timeLimitLabel.Location = new Point(11, 68);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new Size(111, 15);
            timeLimitLabel.TabIndex = 36;
            timeLimitLabel.Text = "Лимит по времени";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(13, 13);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 35;
            idLabel.Text = "ID";
            // 
            // textTextBox
            // 
            textTextBox.Location = new Point(169, 36);
            textTextBox.Name = "textTextBox";
            textTextBox.Size = new Size(176, 23);
            textTextBox.TabIndex = 34;
            // 
            // timeLimitTextBox
            // 
            timeLimitTextBox.Location = new Point(169, 65);
            timeLimitTextBox.Name = "timeLimitTextBox";
            timeLimitTextBox.Size = new Size(51, 23);
            timeLimitTextBox.TabIndex = 33;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(169, 10);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(51, 23);
            idTextBox.TabIndex = 32;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // showDistance
            // 
            showDistance.AutoSize = true;
            showDistance.Location = new Point(13, 212);
            showDistance.Name = "showDistance";
            showDistance.Size = new Size(157, 19);
            showDistance.TabIndex = 62;
            showDistance.Text = "Показывать расстояние";
            showDistance.UseVisualStyleBackColor = true;
            // 
            // contClassname
            // 
            contClassname.FormattingEnabled = true;
            contClassname.Items.AddRange(new object[] { "NSg_Quest_Container_SafeContainer", "ExpansionQuestSeaChest", "ExpansionQuestDryBag_Blue" });
            contClassname.Location = new Point(169, 94);
            contClassname.Name = "contClassname";
            contClassname.Size = new Size(176, 23);
            contClassname.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 97);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 64;
            label1.Text = "ClassName контейнера";
            // 
            // digIn
            // 
            digIn.AutoSize = true;
            digIn.Location = new Point(13, 238);
            digIn.Name = "digIn";
            digIn.Size = new Size(137, 19);
            digIn.TabIndex = 65;
            digIn.Text = "Закопать контейнер";
            digIn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 126);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 70;
            label2.Text = "Название маркера";
            // 
            // markerNameTextBox
            // 
            markerNameTextBox.Location = new Point(169, 123);
            markerNameTextBox.Name = "markerNameTextBox";
            markerNameTextBox.Size = new Size(100, 23);
            markerNameTextBox.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 155);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 72;
            label3.Text = "Тип маркера";
            // 
            // markerVis
            // 
            markerVis.FormattingEnabled = true;
            markerVis.Items.AddRange(new object[] { "2", "4", "6" });
            markerVis.Location = new Point(169, 152);
            markerVis.Name = "markerVis";
            markerVis.Size = new Size(51, 23);
            markerVis.TabIndex = 71;
            // 
            // coordinatesData
            // 
            coordinatesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coordinatesData.Columns.AddRange(new DataGridViewColumn[] { x, y, z });
            coordinatesData.Location = new Point(368, 152);
            coordinatesData.Name = "coordinatesData";
            coordinatesData.Size = new Size(343, 150);
            coordinatesData.TabIndex = 73;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.Name = "x";
            // 
            // y
            // 
            y.HeaderText = "y";
            y.Name = "y";
            // 
            // z
            // 
            z.HeaderText = "z";
            z.Name = "z";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 73);
            label4.Name = "label4";
            label4.Size = new Size(210, 15);
            label4.TabIndex = 74;
            label4.Text = "Возможные координаты контейнера";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 13);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 76;
            label5.Text = "Кол-во предметов";
            // 
            // itemsAmount
            // 
            itemsAmount.Location = new Point(526, 10);
            itemsAmount.Name = "itemsAmount";
            itemsAmount.Size = new Size(51, 23);
            itemsAmount.TabIndex = 75;
            itemsAmount.KeyPress += itemsAmount_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 42);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 78;
            label6.Text = "Макс. дистанция";
            // 
            // maxDidstanceTextBox
            // 
            maxDidstanceTextBox.Location = new Point(526, 39);
            maxDidstanceTextBox.Name = "maxDidstanceTextBox";
            maxDidstanceTextBox.Size = new Size(100, 23);
            maxDidstanceTextBox.TabIndex = 77;
            maxDidstanceTextBox.KeyPress += maxDidstanceTextBox_KeyPress;
            // 
            // cancel
            // 
            cancel.Location = new Point(403, 723);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 80;
            cancel.Text = "Закрыть";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // addTarget
            // 
            addTarget.Location = new Point(238, 723);
            addTarget.Name = "addTarget";
            addTarget.Size = new Size(75, 23);
            addTarget.TabIndex = 79;
            addTarget.Text = "Добавить";
            addTarget.UseVisualStyleBackColor = true;
            addTarget.Click += addTarget_Click;
            // 
            // treasureData
            // 
            treasureData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            treasureData.Columns.AddRange(new DataGridViewColumn[] { ClassName, Chance, Attachments, QuantityPercent, Max, Min, Variants });
            treasureData.Location = new Point(13, 309);
            treasureData.Name = "treasureData";
            treasureData.Size = new Size(700, 408);
            treasureData.TabIndex = 81;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassName.HeaderText = "ClassName";
            ClassName.Name = "ClassName";
            // 
            // Chance
            // 
            Chance.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Chance.HeaderText = "Chance";
            Chance.Name = "Chance";
            Chance.Width = 72;
            // 
            // Attachments
            // 
            Attachments.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Attachments.HeaderText = "Attachments";
            Attachments.Name = "Attachments";
            // 
            // QuantityPercent
            // 
            QuantityPercent.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            QuantityPercent.HeaderText = "QuantityPercent";
            QuantityPercent.Name = "QuantityPercent";
            QuantityPercent.Width = 118;
            // 
            // Max
            // 
            Max.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Max.HeaderText = "Max";
            Max.Name = "Max";
            Max.Width = 55;
            // 
            // Min
            // 
            Min.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Min.HeaderText = "Min";
            Min.Name = "Min";
            Min.Width = 53;
            // 
            // Variants
            // 
            Variants.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Variants.HeaderText = "Variants";
            Variants.Name = "Variants";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(11, 184);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(97, 15);
            filenameLabel.TabIndex = 83;
            filenameLabel.Text = "Название файла";
            // 
            // filenameTextbox
            // 
            filenameTextbox.Location = new Point(169, 181);
            filenameTextbox.Name = "filenameTextbox";
            filenameTextbox.Size = new Size(100, 23);
            filenameTextbox.TabIndex = 82;
            // 
            // addLoot
            // 
            addLoot.Location = new Point(169, 276);
            addLoot.Name = "addLoot";
            addLoot.Size = new Size(75, 23);
            addLoot.TabIndex = 84;
            addLoot.Text = "Добавить";
            addLoot.UseVisualStyleBackColor = true;
            addLoot.Click += addLoot_Click;
            // 
            // removeLoot
            // 
            removeLoot.Location = new Point(270, 272);
            removeLoot.Name = "removeLoot";
            removeLoot.Size = new Size(75, 23);
            removeLoot.TabIndex = 85;
            removeLoot.Text = "Удалить";
            removeLoot.UseVisualStyleBackColor = true;
            removeLoot.Click += removeLoot_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 280);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 86;
            label7.Text = "Содержимое тайника";
            // 
            // xlabel
            // 
            xlabel.AutoSize = true;
            xlabel.Location = new Point(370, 100);
            xlabel.Name = "xlabel";
            xlabel.Size = new Size(115, 15);
            xlabel.TabIndex = 88;
            xlabel.Text = "Координаты из <..>";
            // 
            // coordsTextBox
            // 
            coordsTextBox.Location = new Point(497, 97);
            coordsTextBox.Name = "coordsTextBox";
            coordsTextBox.Size = new Size(214, 23);
            coordsTextBox.TabIndex = 87;
            // 
            // removeCoords
            // 
            removeCoords.Location = new Point(451, 122);
            removeCoords.Name = "removeCoords";
            removeCoords.Size = new Size(75, 23);
            removeCoords.TabIndex = 90;
            removeCoords.Text = "Удалить";
            removeCoords.UseVisualStyleBackColor = true;
            removeCoords.Click += removeCoords_Click;
            // 
            // addCoords
            // 
            addCoords.Location = new Point(370, 122);
            addCoords.Name = "addCoords";
            addCoords.Size = new Size(75, 23);
            addCoords.TabIndex = 89;
            addCoords.Text = "Добавить";
            addCoords.UseVisualStyleBackColor = true;
            addCoords.Click += addCoords_Click;
            // 
            // TreasurePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 767);
            Controls.Add(removeCoords);
            Controls.Add(addCoords);
            Controls.Add(xlabel);
            Controls.Add(coordsTextBox);
            Controls.Add(label7);
            Controls.Add(removeLoot);
            Controls.Add(addLoot);
            Controls.Add(filenameLabel);
            Controls.Add(filenameTextbox);
            Controls.Add(treasureData);
            Controls.Add(cancel);
            Controls.Add(addTarget);
            Controls.Add(label6);
            Controls.Add(maxDidstanceTextBox);
            Controls.Add(label5);
            Controls.Add(itemsAmount);
            Controls.Add(label4);
            Controls.Add(coordinatesData);
            Controls.Add(label3);
            Controls.Add(markerVis);
            Controls.Add(label2);
            Controls.Add(markerNameTextBox);
            Controls.Add(digIn);
            Controls.Add(label1);
            Controls.Add(contClassname);
            Controls.Add(showDistance);
            Controls.Add(textLabel);
            Controls.Add(timeLimitLabel);
            Controls.Add(idLabel);
            Controls.Add(textTextBox);
            Controls.Add(timeLimitTextBox);
            Controls.Add(idTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TreasurePage";
            Text = "TreasurePage";
            ((System.ComponentModel.ISupportInitialize)coordinatesData).EndInit();
            ((System.ComponentModel.ISupportInitialize)treasureData).EndInit();
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
        private CheckBox showDistance;
        private ComboBox contClassname;
        private Label label1;
        private CheckBox digIn;
        private Label label2;
        private TextBox markerNameTextBox;
        private Label label3;
        private ComboBox markerVis;
        private DataGridView coordinatesData;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private DataGridViewTextBoxColumn z;
        private Label label4;
        private Label label5;
        private TextBox itemsAmount;
        private Label label6;
        private TextBox maxDidstanceTextBox;
        private Button cancel;
        private Button addTarget;
        private DataGridView treasureData;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Chance;
        private DataGridViewTextBoxColumn Attachments;
        private DataGridViewTextBoxColumn QuantityPercent;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Variants;
        private Label filenameLabel;
        private TextBox filenameTextbox;
        private Button addLoot;
        private Button removeLoot;
        private Label label7;
        private Label xlabel;
        private TextBox coordsTextBox;
        private Button removeCoords;
        private Button addCoords;
    }
}