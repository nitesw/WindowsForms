using System.Text.RegularExpressions;

namespace Lesson_03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel6.Text = Regex.Matches(textBox1.Text.ToString(), @"\b[a-zA-Z]{1,}\b").Count.ToString();
            toolStripStatusLabel8.Text = Regex.Matches(textBox1.Text.ToString(), @"\b[0-9]{1,}\b").Count.ToString();
            toolStripStatusLabel10.Text = Regex.Matches(textBox1.Text.ToString(), @"[a-zA-Z]").Count.ToString();
            if (textBox1.Text.ToString().Length > numericUpDown1.Value)
            {
                textBox1.ReadOnly = true;
            }
            else
            {
                textBox1.MaxLength = (int)numericUpDown1.Value;
                toolStripProgressBar1.Value = textBox1.Text.ToString().Length;
                toolStripStatusLabel2.Text = textBox1.Text.Length.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Length < numericUpDown1.Value)
            {
                textBox1.ReadOnly = false;
            }
            else
            {
                numericUpDown1.Minimum = textBox1.Text.Length;
            }
            numericUpDown1.Minimum = 0;
            toolStripProgressBar1.Maximum = (int)numericUpDown1.Value;
            toolStripStatusLabel4.Text = numericUpDown1.Value.ToString();
        }
    }
}
