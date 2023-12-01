namespace Lesson_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage($"New tab {tabControl.TabPages.Count + 1}");
            tabPage.UseVisualStyleBackColor = true;

            // label4
            // 
            Label mainLabel = new Label();
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mainLabel.Location = new Point(191, 114);
            mainLabel.Name = "label4";
            mainLabel.Size = new Size(176, 45);
            mainLabel.Text = "Hello User";
            // 
            // label3
            // 
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(91, 191);
            nameLabel.Name = "label3";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            TextBox nameTb = new TextBox();
            nameTb.Location = new Point(152, 188);
            nameTb.Name = "nameTextBox";
            nameTb.Size = new Size(269, 23);
            nameTb.TabIndex = 2;
            // 
            // clearBtn
            // 
            Button clearBtn = new Button();
            clearBtn.Location = new Point(206, 233);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(150, 45);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += (s, args) => { nameTb.Clear(); };

            tabPage.Controls.Add(mainLabel);
            tabPage.Controls.Add(nameLabel);
            tabPage.Controls.Add(nameTb);
            tabPage.Controls.Add(clearBtn);
            tabControl.TabPages.Add(tabPage);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }

        public TextBox SelectedNameTb
        {
            get 
            {
                foreach (var item in tabControl.SelectedTab.Controls.OfType<TextBox>())
                {
                    if (item.Name == "nameTextBox")
                        return item;
                }
                return null;
            }
        }


        /*TextBox GetSelectedTextBox()
        {
            foreach (var item in tabControl.SelectedTab.Controls.OfType<TextBox>())
            {
                if (item.Name == "nameTextBox")
                    return item;
            }
            return null;
        }*/

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected User Name: {SelectedNameTb.Text}");
        }
    }
}