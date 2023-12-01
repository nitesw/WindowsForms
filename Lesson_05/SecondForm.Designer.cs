namespace Lesson_05
{
    partial class SecondForm
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
            closeBtn = new Button();
            label1 = new Label();
            nameLb = new Label();
            showBtn = new Button();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(224, 302);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(217, 45);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Exit";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 49);
            label1.Name = "label1";
            label1.Size = new Size(217, 45);
            label1.TabIndex = 1;
            label1.Text = "Second Form";
            // 
            // nameLb
            // 
            nameLb.AutoSize = true;
            nameLb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameLb.Location = new Point(224, 137);
            nameLb.Name = "nameLb";
            nameLb.Size = new Size(127, 32);
            nameLb.TabIndex = 2;
            nameLb.Text = "Hello, .........";
            // 
            // showBtn
            // 
            showBtn.Location = new Point(224, 251);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(217, 45);
            showBtn.TabIndex = 3;
            showBtn.Text = "Show User";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 414);
            Controls.Add(showBtn);
            Controls.Add(nameLb);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Name = "SecondForm";
            Text = "SecondForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeBtn;
        private Label label1;
        private Label nameLb;
        private Button showBtn;
    }
}