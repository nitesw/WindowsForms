namespace Lesson_05_01
{
    partial class MainForm
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
            productsLB = new ListBox();
            editBtn = new Button();
            infoBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // productsLB
            // 
            productsLB.FormattingEnabled = true;
            productsLB.ItemHeight = 15;
            productsLB.Location = new Point(12, 29);
            productsLB.Name = "productsLB";
            productsLB.Size = new Size(322, 244);
            productsLB.TabIndex = 1;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.Location = new Point(12, 279);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(76, 40);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoBtn.Location = new Point(94, 279);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(76, 40);
            infoBtn.TabIndex = 3;
            infoBtn.Text = "Info";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Location = new Point(176, 279);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(76, 40);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "-";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(258, 279);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(76, 40);
            addBtn.TabIndex = 5;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 328);
            Controls.Add(addBtn);
            Controls.Add(deleteBtn);
            Controls.Add(infoBtn);
            Controls.Add(editBtn);
            Controls.Add(productsLB);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox productsLB;
        private Button editBtn;
        private Button infoBtn;
        private Button deleteBtn;
        private Button addBtn;
    }
}