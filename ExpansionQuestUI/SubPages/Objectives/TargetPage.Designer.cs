namespace ExpansionQuestUI.SubPages.Objectives
{
    partial class TargetPage
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
            idTextBox = new TextBox();
            amountTextBox = new TextBox();
            minDIstTextBox = new TextBox();
            maxdisTextBox = new TextBox();
            zTextBox = new TextBox();
            yTextBox = new TextBox();
            xTextBox = new TextBox();
            timeLimitTextBox = new TextBox();
            textTextBox = new TextBox();
            idLabel = new Label();
            allowedDamageZonesLabel = new Label();
            allowedTargetFactionsLabel = new Label();
            amountLabel = new Label();
            maxDistLabel = new Label();
            yLabel = new Label();
            timeLimitLabel = new Label();
            excludedLabel = new Label();
            classnamesLabel = new Label();
            minDistLabel = new Label();
            zLabel = new Label();
            xlabel = new Label();
            textLabel = new Label();
            classnamesTextBox = new RichTextBox();
            selfkill = new CheckBox();
            allowedDamageZonesTextBox = new RichTextBox();
            allowedTargetFactionsTextBox = new RichTextBox();
            excludedTextBox = new RichTextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            addTarget = new Button();
            cancel = new Button();
            label3 = new Label();
            allowedWeaponsTextBox = new RichTextBox();
            label6 = new Label();
            filenameLabel = new Label();
            filenameTextbox = new TextBox();
            countAI = new CheckBox();
            SuspendLayout();
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(170, 9);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(51, 23);
            idTextBox.TabIndex = 0;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(170, 238);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(100, 23);
            amountTextBox.TabIndex = 8;
            // 
            // minDIstTextBox
            // 
            minDIstTextBox.Location = new Point(170, 209);
            minDIstTextBox.Name = "minDIstTextBox";
            minDIstTextBox.Size = new Size(100, 23);
            minDIstTextBox.TabIndex = 9;
            // 
            // maxdisTextBox
            // 
            maxdisTextBox.Location = new Point(170, 180);
            maxdisTextBox.Name = "maxdisTextBox";
            maxdisTextBox.Size = new Size(100, 23);
            maxdisTextBox.TabIndex = 10;
            // 
            // zTextBox
            // 
            zTextBox.Location = new Point(170, 151);
            zTextBox.Name = "zTextBox";
            zTextBox.Size = new Size(100, 23);
            zTextBox.TabIndex = 11;
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(170, 122);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(100, 23);
            yTextBox.TabIndex = 12;
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(170, 93);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(100, 23);
            xTextBox.TabIndex = 13;
            // 
            // timeLimitTextBox
            // 
            timeLimitTextBox.Location = new Point(170, 64);
            timeLimitTextBox.Name = "timeLimitTextBox";
            timeLimitTextBox.Size = new Size(51, 23);
            timeLimitTextBox.TabIndex = 14;
            // 
            // textTextBox
            // 
            textTextBox.Location = new Point(170, 35);
            textTextBox.Name = "textTextBox";
            textTextBox.Size = new Size(176, 23);
            textTextBox.TabIndex = 15;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(14, 12);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 16;
            idLabel.Text = "ID";
            // 
            // allowedDamageZonesLabel
            // 
            allowedDamageZonesLabel.AutoSize = true;
            allowedDamageZonesLabel.Location = new Point(358, 218);
            allowedDamageZonesLabel.Name = "allowedDamageZonesLabel";
            allowedDamageZonesLabel.Size = new Size(73, 15);
            allowedDamageZonesLabel.TabIndex = 17;
            allowedDamageZonesLabel.Text = "Зоны урона";
            // 
            // allowedTargetFactionsLabel
            // 
            allowedTargetFactionsLabel.AutoSize = true;
            allowedTargetFactionsLabel.Location = new Point(358, 116);
            allowedTargetFactionsLabel.Name = "allowedTargetFactionsLabel";
            allowedTargetFactionsLabel.Size = new Size(91, 15);
            allowedTargetFactionsLabel.TabIndex = 19;
            allowedTargetFactionsLabel.Text = "Фракция целей";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(12, 241);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(46, 15);
            amountLabel.TabIndex = 21;
            amountLabel.Text = "Кол-во";
            // 
            // maxDistLabel
            // 
            maxDistLabel.AutoSize = true;
            maxDistLabel.Location = new Point(12, 183);
            maxDistLabel.Name = "maxDistLabel";
            maxDistLabel.Size = new Size(152, 15);
            maxDistLabel.TabIndex = 22;
            maxDistLabel.Text = "Макс. дистацния убийства";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(12, 125);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(82, 15);
            yLabel.TabIndex = 23;
            yLabel.Text = "Координата Y";
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.AutoSize = true;
            timeLimitLabel.Location = new Point(12, 67);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new Size(111, 15);
            timeLimitLabel.TabIndex = 24;
            timeLimitLabel.Text = "Лимит по времени";
            // 
            // excludedLabel
            // 
            excludedLabel.AutoSize = true;
            excludedLabel.Location = new Point(358, 12);
            excludedLabel.Name = "excludedLabel";
            excludedLabel.Size = new Size(159, 15);
            excludedLabel.TabIndex = 26;
            excludedLabel.Text = "Исключенные класснеймы";
            // 
            // classnamesLabel
            // 
            classnamesLabel.AutoSize = true;
            classnamesLabel.Location = new Point(355, 320);
            classnamesLabel.Name = "classnamesLabel";
            classnamesLabel.Size = new Size(77, 15);
            classnamesLabel.TabIndex = 27;
            classnamesLabel.Text = "Класснеймы";
            // 
            // minDistLabel
            // 
            minDistLabel.AutoSize = true;
            minDistLabel.Location = new Point(12, 212);
            minDistLabel.Name = "minDistLabel";
            minDistLabel.Size = new Size(148, 15);
            minDistLabel.TabIndex = 28;
            minDistLabel.Text = "Мин. дистацния убийства";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Location = new Point(12, 154);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(82, 15);
            zLabel.TabIndex = 29;
            zLabel.Text = "Координата Z";
            // 
            // xlabel
            // 
            xlabel.AutoSize = true;
            xlabel.Location = new Point(12, 96);
            xlabel.Name = "xlabel";
            xlabel.Size = new Size(82, 15);
            xlabel.TabIndex = 30;
            xlabel.Text = "Координата X";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(12, 38);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(76, 15);
            textLabel.TabIndex = 31;
            textLabel.Text = "Текст задачи";
            // 
            // classnamesTextBox
            // 
            classnamesTextBox.Location = new Point(523, 317);
            classnamesTextBox.Name = "classnamesTextBox";
            classnamesTextBox.Size = new Size(176, 96);
            classnamesTextBox.TabIndex = 32;
            classnamesTextBox.Text = "";
            // 
            // selfkill
            // 
            selfkill.AutoSize = true;
            selfkill.Location = new Point(13, 300);
            selfkill.Name = "selfkill";
            selfkill.Size = new Size(328, 19);
            selfkill.TabIndex = 33;
            selfkill.Text = "Засчитывать самоубийство(не трогай если не знаешь)";
            selfkill.UseVisualStyleBackColor = true;
            // 
            // allowedDamageZonesTextBox
            // 
            allowedDamageZonesTextBox.Location = new Point(523, 215);
            allowedDamageZonesTextBox.Name = "allowedDamageZonesTextBox";
            allowedDamageZonesTextBox.Size = new Size(176, 96);
            allowedDamageZonesTextBox.TabIndex = 34;
            allowedDamageZonesTextBox.Text = "";
            // 
            // allowedTargetFactionsTextBox
            // 
            allowedTargetFactionsTextBox.Location = new Point(523, 113);
            allowedTargetFactionsTextBox.Name = "allowedTargetFactionsTextBox";
            allowedTargetFactionsTextBox.Size = new Size(176, 96);
            allowedTargetFactionsTextBox.TabIndex = 35;
            allowedTargetFactionsTextBox.Text = "";
            // 
            // excludedTextBox
            // 
            excludedTextBox.Location = new Point(523, 9);
            excludedTextBox.Name = "excludedTextBox";
            excludedTextBox.Size = new Size(176, 96);
            excludedTextBox.TabIndex = 36;
            excludedTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 131);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 37;
            label1.Text = "(через запятую)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 27);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 38;
            label4.Text = "(через запятую)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 335);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 39;
            label5.Text = "(через запятую)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 237);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 40;
            label2.Text = "(через запятую)";
            // 
            // addTarget
            // 
            addTarget.Location = new Point(20, 353);
            addTarget.Name = "addTarget";
            addTarget.Size = new Size(75, 23);
            addTarget.TabIndex = 41;
            addTarget.Text = "Добавить";
            addTarget.UseVisualStyleBackColor = true;
            addTarget.Click += addTarget_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(185, 350);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 42;
            cancel.Text = "Отмена";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 437);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 45;
            label3.Text = "(через запятую)";
            // 
            // allowedWeaponsTextBox
            // 
            allowedWeaponsTextBox.Location = new Point(523, 419);
            allowedWeaponsTextBox.Name = "allowedWeaponsTextBox";
            allowedWeaponsTextBox.Size = new Size(176, 96);
            allowedWeaponsTextBox.TabIndex = 44;
            allowedWeaponsTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 422);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 43;
            label6.Text = "Разрешенное оружие";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(12, 270);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(97, 15);
            filenameLabel.TabIndex = 47;
            filenameLabel.Text = "Название файла";
            // 
            // filenameTextbox
            // 
            filenameTextbox.Location = new Point(170, 267);
            filenameTextbox.Name = "filenameTextbox";
            filenameTextbox.Size = new Size(100, 23);
            filenameTextbox.TabIndex = 46;
            // 
            // countAI
            // 
            countAI.AutoSize = true;
            countAI.Location = new Point(12, 325);
            countAI.Name = "countAI";
            countAI.Size = new Size(145, 19);
            countAI.TabIndex = 48;
            countAI.Text = "Засчитывать AI ботов";
            countAI.UseVisualStyleBackColor = true;
            // 
            // TargetPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 541);
            Controls.Add(countAI);
            Controls.Add(filenameLabel);
            Controls.Add(filenameTextbox);
            Controls.Add(label3);
            Controls.Add(allowedWeaponsTextBox);
            Controls.Add(label6);
            Controls.Add(cancel);
            Controls.Add(addTarget);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(excludedTextBox);
            Controls.Add(allowedTargetFactionsTextBox);
            Controls.Add(allowedDamageZonesTextBox);
            Controls.Add(selfkill);
            Controls.Add(classnamesTextBox);
            Controls.Add(textLabel);
            Controls.Add(xlabel);
            Controls.Add(zLabel);
            Controls.Add(minDistLabel);
            Controls.Add(classnamesLabel);
            Controls.Add(excludedLabel);
            Controls.Add(timeLimitLabel);
            Controls.Add(yLabel);
            Controls.Add(maxDistLabel);
            Controls.Add(amountLabel);
            Controls.Add(allowedTargetFactionsLabel);
            Controls.Add(allowedDamageZonesLabel);
            Controls.Add(idLabel);
            Controls.Add(textTextBox);
            Controls.Add(timeLimitTextBox);
            Controls.Add(xTextBox);
            Controls.Add(yTextBox);
            Controls.Add(zTextBox);
            Controls.Add(maxdisTextBox);
            Controls.Add(minDIstTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(idTextBox);
            Name = "TargetPage";
            Text = "Target";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTextBox;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox amountTextBox;
        private TextBox minDIstTextBox;
        private TextBox maxdisTextBox;
        private TextBox zTextBox;
        private TextBox yTextBox;
        private TextBox xTextBox;
        private TextBox timeLimitTextBox;
        private TextBox textTextBox;
        private Label idLabel;
        private Label allowedDamageZonesLabel;
        private Label allowedTargetFactionsLabel;
        private Label amountLabel;
        private Label maxDistLabel;
        private Label yLabel;
        private Label timeLimitLabel;
        private Label excludedLabel;
        private Label classnamesLabel;
        private Label minDistLabel;
        private Label zLabel;
        private Label xlabel;
        private Label textLabel;
        private RichTextBox classnamesTextBox;
        private CheckBox selfkill;
        private RichTextBox allowedDamageZonesTextBox;
        private RichTextBox allowedTargetFactionsTextBox;
        private RichTextBox excludedTextBox;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Button addTarget;
        private Button cancel;
        private Label label3;
        private RichTextBox allowedWeaponsTextBox;
        private Label label6;
        private Label filenameLabel;
        private TextBox filenameTextbox;
        private CheckBox countAI;
    }
}