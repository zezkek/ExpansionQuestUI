namespace ExpansionQuestUI.SubPages.ItemPages
{
    partial class CollectItems
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
            add = new Button();
            close = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            minQuantityTextBox = new TextBox();
            classNameTextBox = new TextBox();
            quantityTexBox = new TextBox();
            amountTextBox = new TextBox();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(12, 128);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 0;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // close
            // 
            close.Location = new Point(193, 128);
            close.Name = "close";
            close.Size = new Size(75, 23);
            close.TabIndex = 1;
            close.Text = "Закрыть";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Класснейм";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 3;
            label2.Text = "Минимальное состояние предмета";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(199, 15);
            label3.TabIndex = 4;
            label3.Text = "Обязательное состояние предмета";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 5;
            label4.Text = "Количество";
            // 
            // minQuantityTextBox
            // 
            minQuantityTextBox.Location = new Point(217, 98);
            minQuantityTextBox.Name = "minQuantityTextBox";
            minQuantityTextBox.Size = new Size(51, 23);
            minQuantityTextBox.TabIndex = 6;
            // 
            // classNameTextBox
            // 
            classNameTextBox.Location = new Point(90, 36);
            classNameTextBox.Name = "classNameTextBox";
            classNameTextBox.Size = new Size(178, 23);
            classNameTextBox.TabIndex = 7;
            // 
            // quantityTexBox
            // 
            quantityTexBox.Location = new Point(217, 69);
            quantityTexBox.Name = "quantityTexBox";
            quantityTexBox.Size = new Size(51, 23);
            quantityTexBox.TabIndex = 8;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(90, 6);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(57, 23);
            amountTextBox.TabIndex = 9;
            // 
            // CollectItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 162);
            Controls.Add(amountTextBox);
            Controls.Add(quantityTexBox);
            Controls.Add(classNameTextBox);
            Controls.Add(minQuantityTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(add);
            Name = "CollectItems";
            Text = "CollectItems";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private Button close;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox minQuantityTextBox;
        private TextBox classNameTextBox;
        private TextBox quantityTexBox;
        private TextBox amountTextBox;
    }
}