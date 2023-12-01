using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_07
{
    public partial class NameForm : Form
    {
        private string currentDirectory;
        public string Name { get; set; }
        public string Extension { get; set; }

        public NameForm()
        {
            InitializeComponent();
        }

        public NameForm(string name, string extension, string directoryPath)
        {
            InitializeComponent();
            Name = name;
            Extension = extension;
            currentDirectory = directoryPath;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter proper name!");
                return;
            }
            string newName = textBox1.Text + Extension;

            if (Directory.Exists(Path.Combine(currentDirectory, newName)) || File.Exists(Path.Combine(currentDirectory, newName)))
            {
                MessageBox.Show("A file or folder with the same name already exists in this directory!");
                return;
            }

            Name = newName;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
