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
            timeLimitLabel = new Label();
            maxDistLabel = new Label();
            idLabel = new Label();
            textTextBox = new TextBox();
            timeLimitTextBox = new TextBox();
            coordsTextBox = new TextBox();
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
            xlabel.Size = new Size(115, 15);
            xlabel.TabIndex = 44;
            xlabel.Text = "Координаты из <..>";
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
            // maxDistLabel
            // 
            maxDistLabel.AutoSize = true;
            maxDistLabel.Location = new Point(17, 130);
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
            textTextBox.Location = new Point(134, 39);
            textTextBox.Name = "textTextBox";
            textTextBox.Size = new Size(214, 23);
            textTextBox.TabIndex = 38;
            // 
            // timeLimitTextBox
            // 
            timeLimitTextBox.Location = new Point(134, 68);
            timeLimitTextBox.Name = "timeLimitTextBox";
            timeLimitTextBox.Size = new Size(51, 23);
            timeLimitTextBox.TabIndex = 37;
            // 
            // coordsTextBox
            // 
            coordsTextBox.Location = new Point(134, 97);
            coordsTextBox.Name = "coordsTextBox";
            coordsTextBox.Size = new Size(214, 23);
            coordsTextBox.TabIndex = 36;
            coordsTextBox.KeyPress += xTextBox_KeyPress;
            // 
            // radiusTextBox
            // 
            radiusTextBox.Location = new Point(134, 127);
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(100, 23);
            radiusTextBox.TabIndex = 33;
            radiusTextBox.KeyPress += radiusTextBox_KeyPress;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(134, 13);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(51, 23);
            idTextBox.TabIndex = 32;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 159);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 47;
            label1.Text = "Название маркера";
            // 
            // markerNameTextBox
            // 
            markerNameTextBox.Location = new Point(134, 156);
            markerNameTextBox.Name = "markerNameTextBox";
            markerNameTextBox.Size = new Size(100, 23);
            markerNameTextBox.TabIndex = 46;
            // 
            // onExit
            // 
            onExit.AutoSize = true;
            onExit.Location = new Point(19, 273);
            onExit.Name = "onExit";
            onExit.Size = new Size(228, 19);
            onExit.TabIndex = 48;
            onExit.Text = "Срабатывание на выходе из области";
            onExit.UseVisualStyleBackColor = true;
            // 
            // onEnter
            // 
            onEnter.AutoSize = true;
            onEnter.Location = new Point(19, 248);
            onEnter.Name = "onEnter";
            onEnter.Size = new Size(212, 19);
            onEnter.TabIndex = 49;
            onEnter.Text = "Срабатывание на входе в область";
            onEnter.UseVisualStyleBackColor = true;
            // 
            // showDistance
            // 
            showDistance.AutoSize = true;
            showDistance.Location = new Point(19, 223);
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
            cancel.Location = new Point(220, 298);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 53;
            cancel.Text = "Закрыть";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // addTarget
            // 
            addTarget.Location = new Point(55, 301);
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
            label2.Location = new Point(17, 188);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 55;
            label2.Text = "Название файла";
            // 
            // filenameTextBox
            // 
            filenameTextBox.Location = new Point(134, 185);
            filenameTextBox.Name = "filenameTextBox";
            filenameTextBox.Size = new Size(214, 23);
            filenameTextBox.TabIndex = 54;
            // 
            // TravelPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 337);
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
            Controls.Add(timeLimitLabel);
            Controls.Add(maxDistLabel);
            Controls.Add(idLabel);
            Controls.Add(textTextBox);
            Controls.Add(timeLimitTextBox);
            Controls.Add(coordsTextBox);
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
        private TextBox coordsTextBox;
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