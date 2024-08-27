namespace ExpansionQuestUI.SubPages
{
    partial class QuestItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestItems));
            questItemClassnameLabel = new Label();
            questItemAmountLabel = new Label();
            questItemClassnameTextBox = new TextBox();
            questItemAmountTextBox = new TextBox();
            addQuestItem = new Button();
            closeAddQuestItemForm = new Button();
            SuspendLayout();
            // 
            // questItemClassnameLabel
            // 
            questItemClassnameLabel.AutoSize = true;
            questItemClassnameLabel.Location = new Point(12, 15);
            questItemClassnameLabel.Name = "questItemClassnameLabel";
            questItemClassnameLabel.Size = new Size(66, 15);
            questItemClassnameLabel.TabIndex = 0;
            questItemClassnameLabel.Text = "ClassName";
            // 
            // questItemAmountLabel
            // 
            questItemAmountLabel.AutoSize = true;
            questItemAmountLabel.Location = new Point(27, 52);
            questItemAmountLabel.Name = "questItemAmountLabel";
            questItemAmountLabel.Size = new Size(51, 15);
            questItemAmountLabel.TabIndex = 1;
            questItemAmountLabel.Text = "Amount";
            // 
            // questItemClassnameTextBox
            // 
            questItemClassnameTextBox.Location = new Point(84, 12);
            questItemClassnameTextBox.Name = "questItemClassnameTextBox";
            questItemClassnameTextBox.Size = new Size(286, 23);
            questItemClassnameTextBox.TabIndex = 2;
            // 
            // questItemAmountTextBox
            // 
            questItemAmountTextBox.Location = new Point(84, 49);
            questItemAmountTextBox.Name = "questItemAmountTextBox";
            questItemAmountTextBox.Size = new Size(100, 23);
            questItemAmountTextBox.TabIndex = 3;
            questItemAmountTextBox.KeyPress += questItemAmountTextBox_KeyPress;
            // 
            // addQuestItem
            // 
            addQuestItem.Location = new Point(84, 90);
            addQuestItem.Name = "addQuestItem";
            addQuestItem.Size = new Size(75, 23);
            addQuestItem.TabIndex = 4;
            addQuestItem.Text = "Добавить";
            addQuestItem.UseVisualStyleBackColor = true;
            addQuestItem.Click += addQuestItem_Click;
            // 
            // closeAddQuestItemForm
            // 
            closeAddQuestItemForm.Location = new Point(252, 90);
            closeAddQuestItemForm.Name = "closeAddQuestItemForm";
            closeAddQuestItemForm.Size = new Size(75, 23);
            closeAddQuestItemForm.TabIndex = 5;
            closeAddQuestItemForm.Text = "Закрыть";
            closeAddQuestItemForm.UseVisualStyleBackColor = true;
            closeAddQuestItemForm.Click += closeAddQuestItemForm_Click;
            // 
            // QuestItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 137);
            Controls.Add(closeAddQuestItemForm);
            Controls.Add(addQuestItem);
            Controls.Add(questItemAmountTextBox);
            Controls.Add(questItemClassnameTextBox);
            Controls.Add(questItemAmountLabel);
            Controls.Add(questItemClassnameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuestItems";
            Text = "QuestItems";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questItemClassnameLabel;
        private Label questItemAmountLabel;
        private TextBox questItemClassnameTextBox;
        private TextBox questItemAmountTextBox;
        private Button addQuestItem;
        private Button closeAddQuestItemForm;
    }
}