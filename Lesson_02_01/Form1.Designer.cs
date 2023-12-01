namespace Lesson_02_01
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
            label4 = new Label();
            label5 = new Label();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            phoneMaskedTextBox = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            peopleNumericUpDown = new NumericUpDown();
            label8 = new Label();
            economRadioBtn = new RadioButton();
            standartRadioBtn = new RadioButton();
            luxeRadioBtn = new RadioButton();
            dateMonthCalendar = new MonthCalendar();
            label9 = new Label();
            label10 = new Label();
            addInfoTextBox = new TextBox();
            orderBtn = new Button();
            cancelBtn = new Button();
            agreeCheckBox = new CheckBox();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)peopleNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(252, 20);
            label1.Name = "label1";
            label1.Size = new Size(327, 45);
            label1.TabIndex = 0;
            label1.Text = "Hotel Room Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(172, 27);
            label2.TabIndex = 1;
            label2.Text = "Contact details:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(54, 16);
            label3.TabIndex = 2;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 3;
            label4.Text = "Surname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 4;
            label5.Text = "Phone:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(88, 131);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 23);
            nameTextBox.TabIndex = 5;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(88, 160);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(150, 23);
            surnameTextBox.TabIndex = 6;
            // 
            // phoneMaskedTextBox
            // 
            phoneMaskedTextBox.Location = new Point(88, 189);
            phoneMaskedTextBox.Mask = "+38 (999) 000-00-00";
            phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            phoneMaskedTextBox.Size = new Size(150, 23);
            phoneMaskedTextBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(280, 93);
            label6.Name = "label6";
            label6.Size = new Size(149, 27);
            label6.TabIndex = 8;
            label6.Text = "Order details:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(280, 218);
            label7.Name = "label7";
            label7.Size = new Size(99, 16);
            label7.TabIndex = 9;
            label7.Text = "People count:";
            // 
            // peopleNumericUpDown
            // 
            peopleNumericUpDown.Location = new Point(385, 216);
            peopleNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            peopleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            peopleNumericUpDown.Name = "peopleNumericUpDown";
            peopleNumericUpDown.Size = new Size(44, 23);
            peopleNumericUpDown.TabIndex = 10;
            peopleNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(280, 120);
            label8.Name = "label8";
            label8.Size = new Size(116, 17);
            label8.TabIndex = 11;
            label8.Text = "Hotel room type:";
            // 
            // economRadioBtn
            // 
            economRadioBtn.AutoSize = true;
            economRadioBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            economRadioBtn.Location = new Point(280, 140);
            economRadioBtn.Name = "economRadioBtn";
            economRadioBtn.Size = new Size(76, 20);
            economRadioBtn.TabIndex = 12;
            economRadioBtn.TabStop = true;
            economRadioBtn.Text = "Econom";
            economRadioBtn.UseVisualStyleBackColor = true;
            // 
            // standartRadioBtn
            // 
            standartRadioBtn.AutoSize = true;
            standartRadioBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            standartRadioBtn.Location = new Point(280, 163);
            standartRadioBtn.Name = "standartRadioBtn";
            standartRadioBtn.Size = new Size(83, 20);
            standartRadioBtn.TabIndex = 13;
            standartRadioBtn.TabStop = true;
            standartRadioBtn.Text = "Standart";
            standartRadioBtn.UseVisualStyleBackColor = true;
            // 
            // luxeRadioBtn
            // 
            luxeRadioBtn.AutoSize = true;
            luxeRadioBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            luxeRadioBtn.Location = new Point(280, 186);
            luxeRadioBtn.Name = "luxeRadioBtn";
            luxeRadioBtn.Size = new Size(55, 20);
            luxeRadioBtn.TabIndex = 14;
            luxeRadioBtn.TabStop = true;
            luxeRadioBtn.Text = "Luxe";
            luxeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dateMonthCalendar
            // 
            dateMonthCalendar.Location = new Point(450, 140);
            dateMonthCalendar.MaxSelectionCount = 31;
            dateMonthCalendar.Name = "dateMonthCalendar";
            dateMonthCalendar.ShowTodayCircle = false;
            dateMonthCalendar.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(450, 120);
            label9.Name = "label9";
            label9.Size = new Size(152, 17);
            label9.TabIndex = 16;
            label9.Text = "Staying duration date:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(650, 120);
            label10.Name = "label10";
            label10.Size = new Size(107, 17);
            label10.TabIndex = 17;
            label10.Text = "Additional info:";
            // 
            // addInfoTextBox
            // 
            addInfoTextBox.Location = new Point(650, 140);
            addInfoTextBox.Multiline = true;
            addInfoTextBox.Name = "addInfoTextBox";
            addInfoTextBox.Size = new Size(164, 162);
            addInfoTextBox.TabIndex = 18;
            // 
            // orderBtn
            // 
            orderBtn.Enabled = false;
            orderBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            orderBtn.Location = new Point(12, 373);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(250, 67);
            orderBtn.TabIndex = 20;
            orderBtn.Text = "Order";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.Location = new Point(287, 373);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(250, 67);
            cancelBtn.TabIndex = 21;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // agreeCheckBox
            // 
            agreeCheckBox.AutoSize = true;
            agreeCheckBox.Location = new Point(12, 348);
            agreeCheckBox.Name = "agreeCheckBox";
            agreeCheckBox.Size = new Size(294, 19);
            agreeCheckBox.TabIndex = 22;
            agreeCheckBox.Text = "By checking this box I agree with a term of services";
            agreeCheckBox.UseVisualStyleBackColor = true;
            agreeCheckBox.CheckedChanged += agreeCheckBox_CheckedChanged;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(562, 373);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(250, 67);
            exitBtn.TabIndex = 23;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 453);
            Controls.Add(exitBtn);
            Controls.Add(agreeCheckBox);
            Controls.Add(cancelBtn);
            Controls.Add(orderBtn);
            Controls.Add(addInfoTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateMonthCalendar);
            Controls.Add(luxeRadioBtn);
            Controls.Add(standartRadioBtn);
            Controls.Add(economRadioBtn);
            Controls.Add(label8);
            Controls.Add(peopleNumericUpDown);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(phoneMaskedTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hotel Room Ordering";
            ((System.ComponentModel.ISupportInitialize)peopleNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private MaskedTextBox phoneMaskedTextBox;
        private Label label6;
        private Label label7;
        private NumericUpDown peopleNumericUpDown;
        private Label label8;
        private RadioButton economRadioBtn;
        private RadioButton standartRadioBtn;
        private RadioButton luxeRadioBtn;
        private MonthCalendar dateMonthCalendar;
        private Label label9;
        private Label label10;
        private TextBox addInfoTextBox;
        private Button orderBtn;
        private Button cancelBtn;
        private CheckBox agreeCheckBox;
        private Button exitBtn;
    }
}