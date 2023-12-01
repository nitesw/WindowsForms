namespace Lesson_01
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
            label1 = new Label();
            btnClose = new Button();
            leftMoveBtn = new Button();
            CSharpBtn = new Button();
            rightMoveBtn = new Button();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.LimeGreen;
            btnClick.Font = new Font("Yu Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnClick.ForeColor = Color.FromArgb(0, 64, 64);
            btnClick.Location = new Point(426, 197);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(400, 125);
            btnClick.TabIndex = 0;
            btnClick.Text = "ClickMe";
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += btnClick_Click;
            btnClick.MouseEnter += btnClick_MouseEnter;
            btnClick.MouseLeave += btnClick_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(316, 101);
            label1.Name = "label1";
            label1.Size = new Size(602, 79);
            label1.TabIndex = 1;
            label1.Text = "Hello Windows Forms";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LimeGreen;
            btnClose.Font = new Font("Yu Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(0, 64, 64);
            btnClose.Location = new Point(499, 328);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(250, 125);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // leftMoveBtn
            // 
            leftMoveBtn.Location = new Point(29, 197);
            leftMoveBtn.Name = "leftMoveBtn";
            leftMoveBtn.Size = new Size(150, 50);
            leftMoveBtn.TabIndex = 3;
            leftMoveBtn.Text = "Move Left";
            leftMoveBtn.UseVisualStyleBackColor = true;
            leftMoveBtn.Click += leftMoveBtn_Click;
            // 
            // CSharpBtn
            // 
            CSharpBtn.Location = new Point(553, 519);
            CSharpBtn.Name = "CSharpBtn";
            CSharpBtn.Size = new Size(150, 150);
            CSharpBtn.TabIndex = 4;
            CSharpBtn.Text = "C#";
            CSharpBtn.UseVisualStyleBackColor = true;
            CSharpBtn.Click += CSharpBtn_Click;
            // 
            // rightMoveBtn
            // 
            rightMoveBtn.Location = new Point(1088, 197);
            rightMoveBtn.Name = "rightMoveBtn";
            rightMoveBtn.Size = new Size(150, 50);
            rightMoveBtn.TabIndex = 5;
            rightMoveBtn.Text = "Move Right";
            rightMoveBtn.UseVisualStyleBackColor = true;
            rightMoveBtn.Click += rightMoveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(rightMoveBtn);
            Controls.Add(CSharpBtn);
            Controls.Add(leftMoveBtn);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label label1;
        private Button btnClose;
        private Button leftMoveBtn;
        private Button CSharpBtn;
        private Button rightMoveBtn;
    }
}