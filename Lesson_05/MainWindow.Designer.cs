namespace Lesson_05
{
    partial class MainWindow
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
            openBtn = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            loginBtn = new Button();
            label3 = new Label();
            loginTb = new Label();
            label5 = new Label();
            passwordTb = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 0;
            label1.Text = "Main Form";
            // 
            // openBtn
            // 
            openBtn.Location = new Point(58, 283);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(184, 57);
            openBtn.TabIndex = 1;
            openBtn.Text = "Open new form";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 104);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(410, 283);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(184, 57);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Open login form";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 163);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Login:";
            // 
            // loginTb
            // 
            loginTb.AutoSize = true;
            loginTb.Location = new Point(204, 163);
            loginTb.Name = "loginTb";
            loginTb.Size = new Size(16, 15);
            loginTb.TabIndex = 6;
            loginTb.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 214);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Password:";
            // 
            // passwordTb
            // 
            passwordTb.AutoSize = true;
            passwordTb.Location = new Point(207, 214);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(16, 15);
            passwordTb.TabIndex = 8;
            passwordTb.Text = "...";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 382);
            Controls.Add(passwordTb);
            Controls.Add(label5);
            Controls.Add(loginTb);
            Controls.Add(label3);
            Controls.Add(loginBtn);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(openBtn);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button openBtn;
        private Label label2;
        private TextBox textBox1;
        private Button loginBtn;
        private Label label3;
        private Label loginTb;
        private Label label5;
        private Label passwordTb;
    }
}