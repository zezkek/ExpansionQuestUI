namespace ExpansionQuestUI.SubPages.Objectives
{
    partial class TravelPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelPage));
            textLabel = new Label();
            xlabel = new Label();
            zLabel = new Label();
            timeLimitLabel = new Label();
            yLabel = new Label();
            maxDistLabel = new Label();
            idLabel = new Label();
            textTextBox = new TextBox();
            timeLimitTextBox = new TextBox();
            xTextBox = new TextBox();
            yTextBox = new TextBox();
            zTextBox = new TextBox();
            radiusTextBox = new TextBox();
            idTextBox = new TextBox();
            label1 = new Label();
            markerNameTextBox = new TextBox();
            onExit = new CheckBox();
            onEnter = new CheckBox();
            showDistance = new CheckBox();
            button1 = new Button();
            cancel = new Button();
            addTarget = new Button();
            label2 = new Label();
            filenameTextBox = new TextBox();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(17, 42);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(76, 15);
            textLabel.TabIndex = 45;
            textLabel.Text = "Текст задачи";
            // 
            // xlabel
            // 
            xlabel.AutoSize = true;
            xlabel.Location = new Point(17, 100);
            xlabel.Name = "xlabel";
            xlabel.Size = new Size(82, 15);
            xlabel.TabIndex = 44;
            xlabel.Text = "Координата X";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Location = new Point(17, 158);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(82, 15);
            zLabel.TabIndex = 43;
            zLabel.Text = "Координата Z";
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.AutoSize = true;
            timeLimitLabel.Location = new Point(17, 71);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new Size(111, 15);
            timeLimitLabel.TabIndex = 42;
            timeLimitLabel.Text = "Лимит по времени";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(17, 129);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(82, 15);
            yLabel.TabIndex = 41;
            yLabel.Text = "Координата Y";
            // 
            // maxDistLabel
            // 
            maxDistLabel.AutoSize = true;
            maxDistLabel.Location = new Point(17, 187);
            maxDistLabel.Name = "maxDistLabel";
            maxDistLabel.Size = new Size(93, 15);
            maxDistLabel.TabIndex = 40;
            maxDistLabel.Text = "Радиус области";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(19, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 39;
            idLabel.Text = "ID";
            // 
            // textTextBox
            // 
            textTextBox.Location = new Point(175, 39);
            textTextBox.Name = "textTextBox";
            textTextBox.Size = new Size(176, 23);
            textTextBox.TabIndex = 38;
            // 
            // timeLimitTextBox
            // 
            timeLimitTextBox.Location = new Point(175, 68);
            timeLimitTextBox.Name = "timeLimitTextBox";
            timeLimitTextBox.Size = new Size(51, 23);
            timeLimitTextBox.TabIndex = 37;
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(175, 97);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(100, 23);
            xTextBox.TabIndex = 36;
            xTextBox.KeyPress += xTextBox_KeyPress;
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(175, 126);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(100, 23);
            yTextBox.TabIndex = 35;
            yTextBox.KeyPress += yTextBox_KeyPress;
            // 
            // zTextBox
            // 
            zTextBox.Location = new Point(175, 155);
            zTextBox.Name = "zTextBox";
            zTextBox.Size = new Size(100, 23);
            zTextBox.TabIndex = 34;
            zTextBox.KeyPress += zTextBox_KeyPress;
            // 
            // radiusTextBox
            // 
            radiusTextBox.Location = new Point(175, 184);
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(100, 23);
            radiusTextBox.TabIndex = 33;
            radiusTextBox.KeyPress += radiusTextBox_KeyPress;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(175, 13);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(51, 23);
            idTextBox.TabIndex = 32;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 216);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 47;
            label1.Text = "Название маркера";
            // 
            // markerNameTextBox
            // 
            markerNameTextBox.Location = new Point(175, 213);
            markerNameTextBox.Name = "markerNameTextBox";
            markerNameTextBox.Size = new Size(100, 23);
            markerNameTextBox.TabIndex = 46;
            // 
            // onExit
            // 
            onExit.AutoSize = true;
            onExit.Location = new Point(19, 330);
            onExit.Name = "onExit";
            onExit.Size = new Size(228, 19);
            onExit.TabIndex = 48;
            onExit.Text = "Срабатывание на выходе из области";
            onExit.UseVisualStyleBackColor = true;
            // 
            // onEnter
            // 
            onEnter.AutoSize = true;
            onEnter.Location = new Point(19, 305);
            onEnter.Name = "onEnter";
            onEnter.Size = new Size(212, 19);
            onEnter.TabIndex = 49;
            onEnter.Text = "Срабатывание на входе в область";
            onEnter.UseVisualStyleBackColor = true;
            // 
            // showDistance
            // 
            showDistance.AutoSize = true;
            showDistance.Location = new Point(19, 280);
            showDistance.Name = "showDistance";
            showDistance.Size = new Size(203, 19);
            showDistance.TabIndex = 50;
            showDistance.Text = "Показывать расстояние до цели";
            showDistance.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(542, 112);
            button1.Name = "button1";
            button1.Size = new Size(12, 8);
            button1.TabIndex = 51;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.Location = new Point(220, 355);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 53;
            cancel.Text = "Закрыть";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // addTarget
            // 
            addTarget.Location = new Point(55, 358);
            addTarget.Name = "addTarget";
            addTarget.Size = new Size(75, 23);
            addTarget.TabIndex = 52;
            addTarget.Text = "Добавить";
            addTarget.UseVisualStyleBackColor = true;
            addTarget.Click += addTarget_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 245);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 55;
            label2.Text = "Название файла";
            // 
            // filenameTextBox
            // 
            filenameTextBox.Location = new Point(175, 242);
            filenameTextBox.Name = "filenameTextBox";
            filenameTextBox.Size = new Size(173, 23);
            filenameTextBox.TabIndex = 54;
            // 
            // TravelPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 418);
            Controls.Add(label2);
            Controls.Add(filenameTextBox);
            Controls.Add(cancel);
            Controls.Add(addTarget);
            Controls.Add(button1);
            Controls.Add(showDistance);
            Controls.Add(onEnter);
            Controls.Add(onExit);
            Controls.Add(label1);
            Controls.Add(markerNameTextBox);
            Controls.Add(textLabel);
            Controls.Add(xlabel);
            Controls.Add(zLabel);
            Controls.Add(timeLimitLabel);
            Controls.Add(yLabel);
            Controls.Add(maxDistLabel);
            Controls.Add(idLabel);
            Controls.Add(textTextBox);
            Controls.Add(timeLimitTextBox);
            Controls.Add(xTextBox);
            Controls.Add(yTextBox);
            Controls.Add(zTextBox);
            Controls.Add(radiusTextBox);
            Controls.Add(idTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TravelPage";
            Text = "TravelPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private Label xlabel;
        private Label zLabel;
        private Label timeLimitLabel;
        private Label yLabel;
        private Label maxDistLabel;
        private Label idLabel;
        private TextBox textTextBox;
        private TextBox timeLimitTextBox;
        private TextBox xTextBox;
        private TextBox yTextBox;
        private TextBox zTextBox;
        private TextBox radiusTextBox;
        private TextBox idTextBox;
        private Label label1;
        private TextBox markerNameTextBox;
        private CheckBox onExit;
        private CheckBox onEnter;
        private CheckBox showDistance;
        private Button button1;
        private Button cancel;
        private Button addTarget;
        private Label label2;
        private TextBox filenameTextBox;
    }
}