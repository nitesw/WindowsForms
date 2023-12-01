namespace Lesson_03_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            numericUpDown1 = new NumericUpDown();
            goToTopBtn = new Button();
            startBtn = new Button();
            stopBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            trackBar3 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            panel2 = new Panel();
            trackBar4 = new TrackBar();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            saveToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileAsToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(358, 25);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 30;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(323, 43);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // goToTopBtn
            // 
            goToTopBtn.Location = new Point(12, 146);
            goToTopBtn.Name = "goToTopBtn";
            goToTopBtn.Size = new Size(99, 44);
            goToTopBtn.TabIndex = 2;
            goToTopBtn.Text = "Go to top value";
            goToTopBtn.UseVisualStyleBackColor = true;
            goToTopBtn.Click += goToTopBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(144, 146);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(99, 44);
            startBtn.TabIndex = 3;
            startBtn.Text = "Start time";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(271, 146);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(99, 44);
            stopBtn.TabIndex = 4;
            stopBtn.Text = "Stop timer";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 45);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Top value:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBar3);
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(trackBar1);
            panel1.Location = new Point(472, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 347);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(92, 33);
            label5.Name = "label5";
            label5.Size = new Size(232, 28);
            label5.TabIndex = 6;
            label5.Text = "Change from color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 263);
            label4.Name = "label4";
            label4.Size = new Size(26, 28);
            label4.TabIndex = 5;
            label4.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 183);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 4;
            label3.Text = "G";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 95);
            label2.Name = "label2";
            label2.Size = new Size(26, 28);
            label2.TabIndex = 3;
            label2.Text = "R";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(74, 263);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(314, 45);
            trackBar3.TabIndex = 2;
            trackBar3.TickFrequency = 10;
            trackBar3.TickStyle = TickStyle.None;
            trackBar3.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(74, 183);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(314, 45);
            trackBar2.TabIndex = 1;
            trackBar2.TickFrequency = 10;
            trackBar2.TickStyle = TickStyle.None;
            trackBar2.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(74, 95);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(314, 45);
            trackBar1.TabIndex = 0;
            trackBar1.TickFrequency = 10;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(trackBar4);
            panel2.Location = new Point(895, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 347);
            panel2.TabIndex = 7;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(22, 3);
            trackBar4.Maximum = 100;
            trackBar4.Minimum = 5;
            trackBar4.Name = "trackBar4";
            trackBar4.Orientation = Orientation.Vertical;
            trackBar4.Size = new Size(45, 341);
            trackBar4.TabIndex = 3;
            trackBar4.TickStyle = TickStyle.Both;
            trackBar4.Value = 100;
            trackBar4.ValueChanged += trackBar4_ValueChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripDropDownButton1, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 351);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(993, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(54, 17);
            toolStripStatusLabel1.Text = "Timer: 3s";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            toolStripProgressBar1.Value = 50;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(38, 20);
            toolStripDropDownButton1.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem, fileAsToolStripMenuItem, projectToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(111, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // fileAsToolStripMenuItem
            // 
            fileAsToolStripMenuItem.Name = "fileAsToolStripMenuItem";
            fileAsToolStripMenuItem.Size = new Size(111, 22);
            fileAsToolStripMenuItem.Text = "File as";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(111, 22);
            projectToolStripMenuItem.Text = "Project";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { toolsToolStripMenuItem, windowsToolStripMenuItem, helpToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(48, 20);
            toolStripSplitButton1.Text = "Help";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(180, 22);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(180, 22);
            windowsToolStripMenuItem.Text = "Windows";
            windowsToolStripMenuItem.Click += windowsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(180, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 373);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(goToTopBtn);
            Controls.Add(numericUpDown1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private NumericUpDown numericUpDown1;
        private Button goToTopBtn;
        private Button startBtn;
        private Button stopBtn;
        private Label label1;
        private Panel panel1;
        private TrackBar trackBar4;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileAsToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}