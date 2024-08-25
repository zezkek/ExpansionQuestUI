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
            textLabel = new Label();
            timeLimitLabel = new Label();
            idLabel = new Label();
            textTextBox = new TextBox();
            timeLimitTextBox = new TextBox();
            idTextBox = new TextBox();
            showDistance = new CheckBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            digIn = new CheckBox();
            label2 = new Label();
            markerNameTextBox = new TextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            z = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            maxDidstanceTextBox = new TextBox();
            cancel = new Button();
            addTarget = new Button();
            dataGridView2 = new DataGridView();
            ClassName = new DataGridViewTextBoxColumn();
            Chance = new DataGridViewTextBoxColumn();
            Attachments = new DataGridViewTextBoxColumn();
            QuantityPercent = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Variants = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // 
            // showDistance
            // 
            showDistance.AutoSize = true;
            showDistance.Location = new Point(13, 189);
            showDistance.Name = "showDistance";
            showDistance.Size = new Size(157, 19);
            showDistance.TabIndex = 62;
            showDistance.Text = "Показывать расстояние";
            showDistance.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "NSg_Quest_Container_SafeContainer", "ExpansionQuestSeaChest", "ExpansionQuestDryBag_Blue" });
            comboBox1.Location = new Point(169, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 63;
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
            digIn.Location = new Point(13, 215);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2", "4", "6" });
            comboBox2.Location = new Point(169, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(51, 23);
            comboBox2.TabIndex = 71;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x, y, z });
            dataGridView1.Location = new Point(370, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 150);
            dataGridView1.TabIndex = 73;
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
            // textBox1
            // 
            textBox1.Location = new Point(526, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 75;
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
            // 
            // cancel
            // 
            cancel.Location = new Point(403, 723);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 80;
            cancel.Text = "Закрыть";
            cancel.UseVisualStyleBackColor = true;
            // 
            // addTarget
            // 
            addTarget.Location = new Point(238, 723);
            addTarget.Name = "addTarget";
            addTarget.Size = new Size(75, 23);
            addTarget.TabIndex = 79;
            addTarget.Text = "Добавить";
            addTarget.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ClassName, Chance, Attachments, QuantityPercent, Max, Min, Variants });
            dataGridView2.Location = new Point(13, 309);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(700, 408);
            dataGridView2.TabIndex = 81;
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
            // TreasurePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 767);
            Controls.Add(dataGridView2);
            Controls.Add(cancel);
            Controls.Add(addTarget);
            Controls.Add(label6);
            Controls.Add(maxDidstanceTextBox);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(markerNameTextBox);
            Controls.Add(digIn);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(showDistance);
            Controls.Add(textLabel);
            Controls.Add(timeLimitLabel);
            Controls.Add(idLabel);
            Controls.Add(textTextBox);
            Controls.Add(timeLimitTextBox);
            Controls.Add(idTextBox);
            Name = "TreasurePage";
            Text = "TreasurePage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private ComboBox comboBox1;
        private Label label1;
        private CheckBox digIn;
        private Label label2;
        private TextBox markerNameTextBox;
        private Label label3;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private DataGridViewTextBoxColumn z;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox maxDidstanceTextBox;
        private Button cancel;
        private Button addTarget;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Chance;
        private DataGridViewTextBoxColumn Attachments;
        private DataGridViewTextBoxColumn QuantityPercent;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Variants;
    }
}