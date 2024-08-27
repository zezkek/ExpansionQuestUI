namespace ExpansionQuestUI.SubPages
{
    partial class FilenamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilenamePage));
            createFileButton = new Button();
            cancelFileCreateButton = new Button();
            filenameTextbox = new TextBox();
            filenameLabel = new Label();
            SuspendLayout();
            // 
            // createFileButton
            // 
            createFileButton.Location = new Point(23, 68);
            createFileButton.Name = "createFileButton";
            createFileButton.Size = new Size(75, 23);
            createFileButton.TabIndex = 0;
            createFileButton.Text = "Создать";
            createFileButton.UseVisualStyleBackColor = true;
            createFileButton.Click += createFileButton_Click;
            // 
            // cancelFileCreateButton
            // 
            cancelFileCreateButton.Location = new Point(217, 68);
            cancelFileCreateButton.Name = "cancelFileCreateButton";
            cancelFileCreateButton.Size = new Size(75, 23);
            cancelFileCreateButton.TabIndex = 1;
            cancelFileCreateButton.Text = "Отмена";
            cancelFileCreateButton.UseVisualStyleBackColor = true;
            cancelFileCreateButton.Click += cancelFileCreateButton_Click;
            // 
            // filenameTextbox
            // 
            filenameTextbox.Location = new Point(126, 31);
            filenameTextbox.Name = "filenameTextbox";
            filenameTextbox.Size = new Size(166, 23);
            filenameTextbox.TabIndex = 2;
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(23, 34);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(97, 15);
            filenameLabel.TabIndex = 3;
            filenameLabel.Text = "Название файла";
            // 
            // FilenamePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 123);
            Controls.Add(filenameLabel);
            Controls.Add(filenameTextbox);
            Controls.Add(cancelFileCreateButton);
            Controls.Add(createFileButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilenamePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createFileButton;
        private Button cancelFileCreateButton;
        private TextBox filenameTextbox;
        private Label filenameLabel;
    }
}