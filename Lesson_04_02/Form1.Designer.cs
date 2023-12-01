namespace Lesson_04_02
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
            groupBox1 = new GroupBox();
            showBtn = new Button();
            deleteSelectedBtn = new Button();
            addBtn = new Button();
            volumeNumericUpDown = new NumericUpDown();
            label7 = new Label();
            mileNumericUpDown = new NumericUpDown();
            label6 = new Label();
            colorsComboBox = new ComboBox();
            label5 = new Label();
            yearNumericUpDown = new NumericUpDown();
            label4 = new Label();
            modelTextBox = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            loadFromFileBtn = new Button();
            saveToFileBtn = new Button();
            carListBox = new ListBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mileNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "New Car";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(showBtn);
            groupBox1.Controls.Add(deleteSelectedBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(volumeNumericUpDown);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(mileNumericUpDown);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(colorsComboBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(yearNumericUpDown);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(modelTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 657);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding cars";
            // 
            // showBtn
            // 
            showBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            showBtn.Location = new Point(71, 554);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(260, 68);
            showBtn.TabIndex = 13;
            showBtn.Text = "Show Selected Car";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // deleteSelectedBtn
            // 
            deleteSelectedBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedBtn.Location = new Point(71, 467);
            deleteSelectedBtn.Name = "deleteSelectedBtn";
            deleteSelectedBtn.Size = new Size(260, 68);
            deleteSelectedBtn.TabIndex = 12;
            deleteSelectedBtn.Text = "Delete Selected Car";
            deleteSelectedBtn.UseVisualStyleBackColor = true;
            deleteSelectedBtn.Click += deleteSelectedBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(71, 381);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(260, 68);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add Car";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // volumeNumericUpDown
            // 
            volumeNumericUpDown.DecimalPlaces = 1;
            volumeNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            volumeNumericUpDown.Location = new Point(112, 321);
            volumeNumericUpDown.Maximum = new decimal(new int[] { 60, 0, 0, 65536 });
            volumeNumericUpDown.Name = "volumeNumericUpDown";
            volumeNumericUpDown.Size = new Size(277, 23);
            volumeNumericUpDown.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 321);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 9;
            label7.Text = "Volume:";
            // 
            // mileNumericUpDown
            // 
            mileNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            mileNumericUpDown.Location = new Point(112, 261);
            mileNumericUpDown.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            mileNumericUpDown.Name = "mileNumericUpDown";
            mileNumericUpDown.Size = new Size(277, 23);
            mileNumericUpDown.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 261);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 7;
            label6.Text = "Mileage:";
            // 
            // colorsComboBox
            // 
            colorsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorsComboBox.FormattingEnabled = true;
            colorsComboBox.Items.AddRange(new object[] { "White", "Black", "Grey", "Brown", "Blue", "Purple", "Green", "Yellow", "Orange", "Red", "Pink" });
            colorsComboBox.Location = new Point(94, 201);
            colorsComboBox.Name = "colorsComboBox";
            colorsComboBox.Size = new Size(295, 23);
            colorsComboBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 201);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 5;
            label5.Text = "Color:";
            // 
            // yearNumericUpDown
            // 
            yearNumericUpDown.Location = new Point(94, 141);
            yearNumericUpDown.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            yearNumericUpDown.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            yearNumericUpDown.Name = "yearNumericUpDown";
            yearNumericUpDown.Size = new Size(295, 23);
            yearNumericUpDown.TabIndex = 4;
            yearNumericUpDown.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 141);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 3;
            label4.Text = "Year:";
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(94, 81);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(295, 23);
            modelTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 1;
            label2.Text = "Model:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(loadFromFileBtn);
            groupBox2.Controls.Add(saveToFileBtn);
            groupBox2.Controls.Add(carListBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(431, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(568, 657);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "List of cars";
            // 
            // loadFromFileBtn
            // 
            loadFromFileBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loadFromFileBtn.Location = new Point(295, 583);
            loadFromFileBtn.Name = "loadFromFileBtn";
            loadFromFileBtn.Size = new Size(267, 68);
            loadFromFileBtn.TabIndex = 15;
            loadFromFileBtn.Text = "Load From File";
            loadFromFileBtn.UseVisualStyleBackColor = true;
            loadFromFileBtn.Click += loadFromFileBtn_Click;
            // 
            // saveToFileBtn
            // 
            saveToFileBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveToFileBtn.Location = new Point(6, 583);
            saveToFileBtn.Name = "saveToFileBtn";
            saveToFileBtn.Size = new Size(283, 68);
            saveToFileBtn.TabIndex = 14;
            saveToFileBtn.Text = "Save To File";
            saveToFileBtn.UseVisualStyleBackColor = true;
            saveToFileBtn.Click += saveToFileBtn_Click;
            // 
            // carListBox
            // 
            carListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            carListBox.FormattingEnabled = true;
            carListBox.ItemHeight = 21;
            carListBox.Location = new Point(6, 81);
            carListBox.Name = "carListBox";
            carListBox.SelectionMode = SelectionMode.MultiExtended;
            carListBox.Size = new Size(556, 466);
            carListBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 19);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 1;
            label3.Text = "Cars' list";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 681);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)mileNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox modelTextBox;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private NumericUpDown yearNumericUpDown;
        private Label label4;
        private Label label7;
        private NumericUpDown mileNumericUpDown;
        private Label label6;
        private ComboBox colorsComboBox;
        private Label label5;
        private NumericUpDown volumeNumericUpDown;
        private Button showBtn;
        private Button deleteSelectedBtn;
        private Button addBtn;
        private Button loadFromFileBtn;
        private Button saveToFileBtn;
        private ListBox carListBox;
    }
}