namespace Lesson_04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            showBtn = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            orderComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            addBtn = new Button();
            removeBtn = new Button();
            showSelectedBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Select your city:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 38);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Select your city:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 38);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Select your city:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Rivne", "Odessa", "Lviv", "Kyiv", "Poltava", "Kharkiv", "Uzhorod" });
            comboBox1.Location = new Point(32, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 90);
            comboBox1.TabIndex = 3;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(32, 164);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(172, 30);
            showBtn.TabIndex = 6;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Rivne", "Odessa", "Lviv", "Kyiv", "Poltava", "Kharkiv", "Uzhorod" });
            comboBox2.Location = new Point(247, 56);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(172, 23);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Rivne", "Odessa", "Lviv", "Kyiv", "Poltava", "Kharkiv", "Uzhorod" });
            comboBox3.Location = new Point(460, 56);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(172, 23);
            comboBox3.TabIndex = 8;
            // 
            // orderComboBox
            // 
            orderComboBox.FormattingEnabled = true;
            orderComboBox.Location = new Point(32, 276);
            orderComboBox.Name = "orderComboBox";
            orderComboBox.Size = new Size(172, 23);
            orderComboBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 258);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 9;
            label4.Text = "Select order:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 258);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 11;
            label5.Text = "Order price:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(247, 276);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(172, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(460, 276);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 46);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add new order";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(460, 348);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(172, 46);
            removeBtn.TabIndex = 14;
            removeBtn.Text = "Remove selected order";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // showSelectedBtn
            // 
            showSelectedBtn.Location = new Point(460, 422);
            showSelectedBtn.Name = "showSelectedBtn";
            showSelectedBtn.Size = new Size(172, 46);
            showSelectedBtn.TabIndex = 15;
            showSelectedBtn.Text = "Show selected order";
            showSelectedBtn.UseVisualStyleBackColor = true;
            showSelectedBtn.Click += showSelectedBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 497);
            Controls.Add(showSelectedBtn);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(orderComboBox);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(showBtn);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button showBtn;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox orderComboBox;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button addBtn;
        private Button removeBtn;
        private Button showSelectedBtn;
    }
}