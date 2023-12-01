namespace Lesson_03
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            orderBtn = new Button();
            clearBtn = new Button();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(128, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select meal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 156);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "2$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 100);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 4;
            label2.Text = "3$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 42);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 3;
            label1.Text = "1$";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 154);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Tag = "2";
            radioButton3.Text = "Fries";
            toolTip3.SetToolTip(radioButton3, "Has pineapple!!!");
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 98);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Tag = "3";
            radioButton2.Text = "Sandwich";
            toolTip2.SetToolTip(radioButton2, "Make with cat!!!");
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Tag = "1";
            radioButton1.Text = "Hot-dog";
            toolTip1.SetToolTip(radioButton1, "Bread, sausage, cheese, ketchup");
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(492, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Drink:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 156);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 8;
            label6.Text = "1$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 100);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 7;
            label5.Text = "2$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 42);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 6;
            label4.Text = "1$";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 154);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(54, 19);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Tag = "1";
            radioButton4.Text = "Fanta";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 98);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(55, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Tag = "2";
            radioButton5.Text = "Sprite";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 40);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(53, 19);
            radioButton6.TabIndex = 3;
            radioButton6.TabStop = true;
            radioButton6.Tag = "1";
            radioButton6.Text = "Pepsi";
            toolTip1.SetToolTip(radioButton6, "Has many sugar");
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // orderBtn
            // 
            orderBtn.Enabled = false;
            orderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderBtn.Location = new Point(128, 310);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(135, 47);
            orderBtn.TabIndex = 2;
            orderBtn.Text = "Order";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.Location = new Point(492, 310);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(135, 47);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "Clear";
            toolTip4.SetToolTip(clearBtn, "All info will be deleted");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(774, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(309, 208);
            textBox1.TabIndex = 4;
            toolTip4.SetToolTip(textBox1, "Read only field");
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Reciept:";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Warning;
            toolTip2.ToolTipTitle = "Danger!!!";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Error;
            toolTip3.ToolTipTitle = "Attention!!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 450);
            Controls.Add(textBox1);
            Controls.Add(clearBtn);
            Controls.Add(orderBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button orderBtn;
        private Button clearBtn;
        private Label label1;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
    }
}