namespace Lesson_09_01
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
            colorList = new ComboBox();
            typeList = new ComboBox();
            SuspendLayout();
            // 
            // colorList
            // 
            colorList.FormattingEnabled = true;
            colorList.Location = new Point(12, 12);
            colorList.Name = "colorList";
            colorList.Size = new Size(160, 23);
            colorList.TabIndex = 0;
            // 
            // typeList
            // 
            typeList.FormattingEnabled = true;
            typeList.Location = new Point(188, 12);
            typeList.Name = "typeList";
            typeList.Size = new Size(160, 23);
            typeList.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(typeList);
            Controls.Add(colorList);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox colorList;
        private ComboBox typeList;
    }
}