using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson_06_01
{
    public partial class Form1 : Form
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Form1()
        {
            InitializeComponent();

            OpenTabs();
            SaveTabs();

            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;

            //AddTab();

            tabControl.ContextMenuStrip = contextMenuStrip4;

            //richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamily.GenericMonospace, 25, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = checkBox1.Checked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DesktopPath + @"\FileText.rtf", RichTextBoxStreamType.RichText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(DesktopPath + @"\FileText.rtf", RichTextBoxStreamType.RichText);
        }*/

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTabs();
            this.Close();
        }

        private void makeBulletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.SelectionBullet = makeBulletToolStripMenuItem.Checked;
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                FontDialog font = new FontDialog();
                if (font.ShowDialog() == DialogResult.OK)
                {
                    RichTextBoxForSelectedTab.SelectionFont = font.Font;
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                ColorDialog color = new ColorDialog();
                if (color.ShowDialog() == DialogResult.OK)
                {
                    RichTextBoxForSelectedTab.SelectionColor = color.Color;
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                ColorDialog color = new ColorDialog();
                if (color.ShowDialog() == DialogResult.OK)
                {
                    RichTextBoxForSelectedTab.SelectionBackColor = color.Color;
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();

                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    string textToPrint = RichTextBoxForSelectedTab.Text;
                    printDocument.PrintPage += (s, ev) =>
                    {
                        ev.Graphics.DrawString(textToPrint, RichTextBoxForSelectedTab.Font, Brushes.Black, ev.MarginBounds);
                    };

                    printDocument.Print();
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.Undo();
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.Redo();
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.Cut();
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.Copy();
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.Paste();
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                if (RichTextBoxForSelectedTab.SelectedText == "")
                {
                    int selectionStart = RichTextBoxForSelectedTab.SelectionStart;

                    if (selectionStart < RichTextBoxForSelectedTab.TextLength)
                    {
                        FontStyle nextCharStyle = RichTextBoxForSelectedTab.SelectionFont.Style;
                        Color nextCharColor = RichTextBoxForSelectedTab.SelectionColor;

                        RichTextBoxForSelectedTab.Select(selectionStart, 1);
                        RichTextBoxForSelectedTab.SelectedText = "";

                        RichTextBoxForSelectedTab.Select(selectionStart, 0);
                        RichTextBoxForSelectedTab.SelectionFont = new Font(RichTextBoxForSelectedTab.Font, nextCharStyle);
                        RichTextBoxForSelectedTab.SelectionColor = nextCharColor;
                    }
                }
                else
                {
                    FontStyle currentStyle = RichTextBoxForSelectedTab.SelectionFont.Style;
                    Color currentColor = RichTextBoxForSelectedTab.SelectionColor;

                    RichTextBoxForSelectedTab.SelectedText = "";

                    RichTextBoxForSelectedTab.SelectionFont = new Font(RichTextBoxForSelectedTab.Font, currentStyle);
                    RichTextBoxForSelectedTab.SelectionColor = currentColor;
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.SelectAll();
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void richTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string item = e.Data.GetData(DataFormats.Text).ToString();
                RichTextBoxForSelectedTab.Text += item;
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    string fileText = File.ReadAllText(filePath);
                    RichTextBoxForSelectedTab.Text += fileText;
                }
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.TextChanged -= richTextBox1_TextChanged;
                RichTextBoxForSelectedTab.TextChanged += richTextBox1_TextChanged;

                richTextBox1_TextChanged(sender, e);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            countWordsLabel.Text = Regex.Matches(RichTextBoxForSelectedTab.Text.ToString(), @"[a-zA-Z]{1,}").Count.ToString();
            countDigitsLabel.Text = Regex.Matches(RichTextBoxForSelectedTab.Text.ToString(), @"[0-9]").Count.ToString();
            countLettersLabel.Text = Regex.Matches(RichTextBoxForSelectedTab.Text.ToString(), @"[a-zA-Z]").Count.ToString();
            countSymbolsLabel.Text = Regex.Matches(RichTextBoxForSelectedTab.Text.ToString(), @"\W").Count.ToString();
            countAllCharactersLabel.Text = RichTextBoxForSelectedTab.Text.Length.ToString();
        }

        public RichTextBox RichTextBoxForSelectedTab
        {
            get
            {
                foreach (var item in tabControl.SelectedTab.Controls.OfType<RichTextBox>())
                {
                    if (item.Name == "mainRichTextBox")
                        return item;
                }
                return null;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                openFileDialog.Filter = "All file(*.*)|*.*|Text files(*.txt)|*.txt||";
                openFileDialog.FilterIndex = 2;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string message = File.ReadAllText(openFileDialog.FileName);

                    RichTextBoxForSelectedTab.Text = message;

                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    tabControl.SelectedTab.Text = fileName;

                    tabControl.SelectedTab.Tag = openFileDialog.FileName;

                    SaveTabs();
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                string currentTabText = tabControl.SelectedTab.Text;
                if (currentTabText.StartsWith("Untitled"))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //saveFileDialog.CreatePrompt = true;
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";

                    saveFileDialog.FilterIndex = 1;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        tabControl.SelectedTab.Tag = fileName;
                        File.WriteAllText(fileName, RichTextBoxForSelectedTab.Text);

                        string tabText = Path.GetFileName(fileName);
                        tabControl.SelectedTab.Text = tabText;

                        SaveTabs();
                    }
                }
                else
                {
                    string fileName = (string)tabControl.SelectedTab.Tag;

                    File.WriteAllText(fileName, RichTextBoxForSelectedTab.Text);
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                //saveFileDialog.CreatePrompt = true;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";

                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    File.WriteAllText(fileName, RichTextBoxForSelectedTab.Text);

                    string tabText = Path.GetFileName(fileName);
                    tabControl.SelectedTab.Text = tabText;

                    tabControl.SelectedTab.Tag = saveFileDialog.FileName;

                    SaveTabs();
                }
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you want to save the current file?", "Warning!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //saveFileDialog.CreatePrompt = true;
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, RichTextBoxForSelectedTab.Text);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

                tabControl.SelectedTab.Text = $"Untitled {tabControl.TabPages.Count + 1}";
                RichTextBoxForSelectedTab.Clear();
                tabControl.SelectedTab.Tag = null; 
                SaveTabs();
            }
            else
            {
                AddTab();
            }

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                RichTextBoxForSelectedTab.SelectAll();
                RichTextBoxForSelectedTab.SelectionFont = DefaultFont;
                RichTextBoxForSelectedTab.SelectionColor = DefaultForeColor;
                RichTextBoxForSelectedTab.SelectionBackColor = DefaultBackColor;
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you want to save the current file?", "Warning!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //saveFileDialog.CreatePrompt = true;
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, RichTextBoxForSelectedTab.Text);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                SaveTabs();
            }
            else
            {
                MessageBox.Show("You need to select a tab at first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTab()
        {
            TabPage tabPage = new TabPage($"Untitled {tabControl.TabPages.Count + 1}");
            tabPage.UseVisualStyleBackColor = true;

            #region Adding Elems
            // 
            // richTextBox1
            // 
            RichTextBox mainRichTextBox = new RichTextBox();
            mainRichTextBox.ContextMenuStrip = contextMenuStrip1;
            mainRichTextBox.Location = new Point(3, 3);
            mainRichTextBox.Name = "mainRichTextBox";
            mainRichTextBox.Size = new Size(994, 618);
            mainRichTextBox.TabIndex = 13;
            mainRichTextBox.Text = "";
            #endregion

            mainRichTextBox.TextChanged += new EventHandler(richTextBox1_TextChanged);

            tabPage.Controls.Add(mainRichTextBox);

            mainRichTextBox.AllowDrop = true;
            mainRichTextBox.DragEnter += new DragEventHandler(richTextBox_DragEnter);
            mainRichTextBox.DragDrop += new DragEventHandler(richTextBox_DragDrop);

            tabPage.Tag = null;

            tabControl.TabPages.Add(tabPage);

            SaveTabs();
        }

        private void SaveTabs()
        {
            List<string> paths = new List<string>();
            int countUntitled = 0;

            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if(tabPage.Tag != null)
                {
                    paths.Add((string)tabPage.Tag);
                }
                else
                {
                    countUntitled++;
                }
            }

            string filePath = "tabPaths.txt";
            string untitledFilePath = "untitledFiles.txt";
            try
            {
                File.WriteAllLines(filePath, paths);
                File.WriteAllText(untitledFilePath, countUntitled.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OpenTabs()
        {
            string filePath = "tabPaths.txt";
            string untitledFilePath = "untitledFiles.txt";
            try
            {
                if (File.Exists(filePath) && File.Exists(untitledFilePath))
                {
                    string[] savedPaths = File.ReadAllLines(filePath);

                    foreach (string path in savedPaths)
                    {
                        TabPage tabPage = new TabPage(Path.GetFileName(path));
                        tabPage.UseVisualStyleBackColor = true;

                        RichTextBox mainRichTextBox = new RichTextBox();
                        mainRichTextBox.ContextMenuStrip = contextMenuStrip1;
                        mainRichTextBox.Location = new Point(3, 3);
                        mainRichTextBox.Name = "mainRichTextBox";
                        mainRichTextBox.Size = new Size(994, 618);
                        mainRichTextBox.TabIndex = 13;
                        mainRichTextBox.Text = File.ReadAllText(path);

                        mainRichTextBox.TextChanged += new EventHandler(richTextBox1_TextChanged);

                        tabPage.Controls.Add(mainRichTextBox);

                        mainRichTextBox.AllowDrop = true;
                        mainRichTextBox.DragEnter += new DragEventHandler(richTextBox_DragEnter);
                        mainRichTextBox.DragDrop += new DragEventHandler(richTextBox_DragDrop);

                        tabPage.Tag = path;

                        tabControl.TabPages.Add(tabPage);
                    }

                    string countString = File.ReadAllText(untitledFilePath);
                    if (int.TryParse(countString, out int count))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            AddTab();
                        }
                    }
                }
                else if(File.Exists(filePath))
                {
                    string[] savedPaths = File.ReadAllLines(filePath);

                    foreach (string path in savedPaths)
                    {
                        TabPage tabPage = new TabPage(Path.GetFileName(path));
                        tabPage.UseVisualStyleBackColor = true;

                        RichTextBox mainRichTextBox = new RichTextBox();
                        mainRichTextBox.ContextMenuStrip = contextMenuStrip1;
                        mainRichTextBox.Location = new Point(3, 3);
                        mainRichTextBox.Name = "mainRichTextBox";
                        mainRichTextBox.Size = new Size(994, 618);
                        mainRichTextBox.TabIndex = 13;
                        mainRichTextBox.Text = File.ReadAllText(path);

                        mainRichTextBox.TextChanged += new EventHandler(richTextBox1_TextChanged);

                        tabPage.Controls.Add(mainRichTextBox);

                        mainRichTextBox.AllowDrop = true;
                        mainRichTextBox.DragEnter += new DragEventHandler(richTextBox_DragEnter);
                        mainRichTextBox.DragDrop += new DragEventHandler(richTextBox_DragDrop);

                        tabPage.Tag = path;

                        tabControl.TabPages.Add(tabPage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}