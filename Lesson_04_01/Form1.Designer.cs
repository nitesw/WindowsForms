namespace Lesson_04_01
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
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            moveRightBtn = new Button();
            moveLeftBtn = new Button();
            textBox1 = new TextBox();
            addBtn = new Button();
            removeSelectedBtn = new Button();
            showSelectedBtn = new Button();
            deleteCheckedBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "List box:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(495, 31);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 1;
            label2.Text = "Checked list box:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "Yellow", "Gray", "Orange", "Brown" });
            listBox1.Location = new Point(12, 59);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(296, 259);
            listBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "Yellow", "Gray", "Orange", "Brown" });
            checkedListBox1.Location = new Point(435, 59);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(296, 256);
            checkedListBox1.TabIndex = 3;
            // 
            // moveRightBtn
            // 
            moveRightBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            moveRightBtn.Location = new Point(335, 104);
            moveRightBtn.Name = "moveRightBtn";
            moveRightBtn.Size = new Size(75, 66);
            moveRightBtn.TabIndex = 4;
            moveRightBtn.Text = "-->";
            moveRightBtn.UseVisualStyleBackColor = true;
            moveRightBtn.Click += moveRightBtn_Click;
            // 
            // moveLeftBtn
            // 
            moveLeftBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            moveLeftBtn.Location = new Point(335, 203);
            moveLeftBtn.Name = "moveLeftBtn";
            moveLeftBtn.Size = new Size(75, 66);
            moveLeftBtn.TabIndex = 5;
            moveLeftBtn.Text = "<--";
            moveLeftBtn.UseVisualStyleBackColor = true;
            moveLeftBtn.Click += moveLeftBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 346);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 6;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(272, 335);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(36, 34);
            addBtn.TabIndex = 7;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // removeSelectedBtn
            // 
            removeSelectedBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedBtn.Location = new Point(12, 459);
            removeSelectedBtn.Name = "removeSelectedBtn";
            removeSelectedBtn.Size = new Size(296, 50);
            removeSelectedBtn.TabIndex = 9;
            removeSelectedBtn.Text = "Remove Selected Items";
            removeSelectedBtn.UseVisualStyleBackColor = true;
            removeSelectedBtn.Click += removeSelectedBtn_Click;
            // 
            // showSelectedBtn
            // 
            showSelectedBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            showSelectedBtn.Location = new Point(12, 403);
            showSelectedBtn.Name = "showSelectedBtn";
            showSelectedBtn.Size = new Size(296, 50);
            showSelectedBtn.TabIndex = 10;
            showSelectedBtn.Text = "Show Selection";
            showSelectedBtn.UseVisualStyleBackColor = true;
            showSelectedBtn.Click += showSelectedBtn_Click;
            // 
            // deleteCheckedBtn
            // 
            deleteCheckedBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteCheckedBtn.Location = new Point(435, 459);
            deleteCheckedBtn.Name = "deleteCheckedBtn";
            deleteCheckedBtn.Size = new Size(296, 50);
            deleteCheckedBtn.TabIndex = 11;
            deleteCheckedBtn.Text = "Delete Checked Items";
            deleteCheckedBtn.UseVisualStyleBackColor = true;
            deleteCheckedBtn.Click += deleteCheckedBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(deleteCheckedBtn);
            Controls.Add(showSelectedBtn);
            Controls.Add(removeSelectedBtn);
            Controls.Add(addBtn);
            Controls.Add(textBox1);
            Controls.Add(moveLeftBtn);
            Controls.Add(moveRightBtn);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
        private Button moveRightBtn;
        private Button moveLeftBtn;
        private TextBox textBox1;
        private Button addBtn;
        private Button removeSelectedBtn;
        private Button showSelectedBtn;
        private Button deleteCheckedBtn;
    }
}