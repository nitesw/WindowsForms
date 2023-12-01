using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_05
{
    public partial class SecondForm : Form
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set 
            { 
                userName = value;
                nameLb.Text = $"Hello, {userName}";
            }
        }

        public SecondForm()
        {
            InitializeComponent();
        }
        public SecondForm(string name)
        {
            InitializeComponent();
            UserName = name;
            nameLb.Text = $"Hello, {UserName}";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Username: {UserName}");
        }
        public void Show(string name)
        {
            UserName = name;
            this.Show();
        }
    }
}
