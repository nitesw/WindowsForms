namespace Lesson_06
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
            openFileBtn = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            saveFileBtn = new Button();
            openFolderBtn = new Button();
            backColorBtn = new Button();
            fontBtn = new Button();
            SuspendLayout();
            // 
            // openFileBtn
            // 
            openFileBtn.Location = new Point(44, 43);
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(155, 62);
            openFileBtn.TabIndex = 0;
            openFileBtn.Text = "Open";
            openFileBtn.UseVisualStyleBackColor = true;
            openFileBtn.Click += openFileBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 137);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 361);
            textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(644, 137);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(329, 361);
            listBox1.TabIndex = 6;
            // 
            // saveFileBtn
            // 
            saveFileBtn.Location = new Point(244, 43);
            saveFileBtn.Name = "saveFileBtn";
            saveFileBtn.Size = new Size(155, 62);
            saveFileBtn.TabIndex = 7;
            saveFileBtn.Text = "Save";
            saveFileBtn.UseVisualStyleBackColor = true;
            saveFileBtn.Click += saveFileBtn_Click;
            // 
            // openFolderBtn
            // 
            openFolderBtn.Location = new Point(818, 43);
            openFolderBtn.Name = "openFolderBtn";
            openFolderBtn.Size = new Size(155, 62);
            openFolderBtn.TabIndex = 8;
            openFolderBtn.Text = "Open Folder";
            openFolderBtn.UseVisualStyleBackColor = true;
            openFolderBtn.Click += openFolderBtn_Click;
            // 
            // backColorBtn
            // 
            backColorBtn.Location = new Point(44, 521);
            backColorBtn.Name = "backColorBtn";
            backColorBtn.Size = new Size(226, 71);
            backColorBtn.TabIndex = 9;
            backColorBtn.Text = "Background Color";
            backColorBtn.UseVisualStyleBackColor = true;
            backColorBtn.Click += backColorBtn_Click;
            // 
            // fontBtn
            // 
            fontBtn.Location = new Point(375, 521);
            fontBtn.Name = "fontBtn";
            fontBtn.Size = new Size(220, 71);
            fontBtn.TabIndex = 10;
            fontBtn.Text = "Font";
            fontBtn.UseVisualStyleBackColor = true;
            fontBtn.Click += fontBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(fontBtn);
            Controls.Add(backColorBtn);
            Controls.Add(openFolderBtn);
            Controls.Add(saveFileBtn);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(openFileBtn);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFileBtn;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button saveFileBtn;
        private Button openFolderBtn;
        private Button backColorBtn;
        private Button fontBtn;
    }
}