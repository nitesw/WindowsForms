namespace Lesson_02
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
            btnClick = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            label11 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.Red;
            btnClick.FlatAppearance.BorderColor = Color.Maroon;
            btnClick.FlatAppearance.BorderSize = 6;
            btnClick.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnClick.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnClick.FlatStyle = FlatStyle.Flat;
            btnClick.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClick.Location = new Point(804, 334);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(157, 49);
            btnClick.TabIndex = 0;
            btnClick.Text = "Order";
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += btnClick_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox1.Location = new Point(13, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Breakfast";
            checkBox1.ThreeState = true;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(13, 126);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(59, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Lunch";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(13, 151);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(61, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Dinner";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 73);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 4;
            label1.Text = "Select a meal:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Economy";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Standart";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 77);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Fast";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 8;
            label2.Text = "Select delivery:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 24);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "PayPal";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 47);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(58, 24);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "Card";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 22);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(76, 24);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "By cash";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton3);
            panel1.Location = new Point(155, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 115);
            panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(329, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 114);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment methods:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(341, 9);
            label3.Name = "label3";
            label3.Size = new Size(210, 45);
            label3.TabIndex = 15;
            label3.Text = "Order meal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(589, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 107);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 17;
            label4.Text = "Login:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(589, 136);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 136);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 20;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 165);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 21;
            label6.Text = "Phone:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(589, 165);
            maskedTextBox1.Mask = "+38 (999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(129, 23);
            maskedTextBox1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(523, 74);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 23;
            label7.Text = "Details:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(795, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(755, 107);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 25;
            label8.Text = "Date:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(795, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(737, 136);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 27;
            label9.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(725, 165);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 28;
            label10.Text = "Comment:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(795, 165);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(166, 113);
            textBox4.TabIndex = 29;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(13, 221);
            monthCalendar1.MaxSelectionCount = 5;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(194, 221);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 31;
            label11.Text = "Count:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(243, 221);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 23);
            numericUpDown1.TabIndex = 32;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(659, 334);
            button1.Name = "button1";
            button1.Size = new Size(130, 49);
            button1.TabIndex = 33;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 400);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label11);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(maskedTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private Label label10;
        private TextBox textBox4;
        private MonthCalendar monthCalendar1;
        private Label label11;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}