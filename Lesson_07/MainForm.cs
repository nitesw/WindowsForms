namespace Lesson_07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeDirTree();

            fileList.View = View.Details;
            fileList.Columns.Add("Name", 125);
            fileList.Columns.Add("Extension", 125);
            fileList.Columns.Add("Create time", 125);
        }
        private void InitializeDirTree()
        {
            dirTree.Nodes.Clear();
            LoadImages();
            LoadDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dirTree.Nodes);
        }
        void LoadImages()
        {
            ImageList list = new ImageList();
            list.Images.Add(new Bitmap(@"E:\ITStep_WindwosForms_Lessons\Lessons\Lesson_07\folder.png"));
            list.Images.Add(new Bitmap(@"E:\ITStep_WindwosForms_Lessons\Lessons\Lesson_07\openFolder.png"));
            list.Images.Add(new Bitmap(@"E:\ITStep_WindwosForms_Lessons\Lessons\Lesson_07\select.png"));

            dirTree.ImageList = list;
            dirTree.ImageList.ImageSize = new Size(16, 16);
        }
        void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            foreach (var subDir in dir.GetDirectories())
            {
                //dirTree.Nodes.Add(subDir.Name);
                TreeNode newNode = new TreeNode(subDir.Name, 0, 2);
                newNode.Tag = subDir.FullName;

                nodes.Add(newNode);
                if (subDir.GetDirectories().Length > 0)
                    LoadDirectories(subDir.FullName, newNode.Nodes);
            }
        }

        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dirTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fileList.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var file in dir.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.CreationTime.ToString());

                fileList.Items.Add(item);
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileList.View = View.LargeIcon;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileList.View = View.SmallIcon;
        }

        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileList.View = View.Tile;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileList.View = View.Details;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileList.View = View.List;
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = dirTree.SelectedNode;

            if (selectedNode == null || selectedNode.Tag == null)
            {
                MessageBox.Show("Please select a directory to create a new folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string selectedDirPath = selectedNode.Tag.ToString();

            NameForm nameForm = new NameForm("", "", selectedDirPath);
            if (nameForm.ShowDialog() == DialogResult.OK)
            {
                string newFolderName = nameForm.Name;

                try
                {
                    string newFolderPath = Path.Combine(selectedDirPath, newFolderName);

                    if (Directory.Exists(newFolderPath))
                    {
                        MessageBox.Show("Folder with the same name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Directory.CreateDirectory(newFolderPath);

                    InitializeDirTree();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = dirTree.SelectedNode;

            if (selectedNode == null || selectedNode.Tag == null)
            {
                MessageBox.Show("Please select a directory to create a new file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedDirPath = selectedNode.Tag.ToString();

            NameForm nameForm = new NameForm("", ".txt", selectedDirPath);
            if (nameForm.ShowDialog() == DialogResult.OK)
            {
                string newFileName = nameForm.Name;

                try
                {
                    string fullFilePath = Path.Combine(selectedDirPath, newFileName);

                    if (File.Exists(fullFilePath))
                    {
                        MessageBox.Show("File with the same name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    File.Create(fullFilePath);

                    InitializeDirTree();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void copyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = dirTree.SelectedNode;

            if (selectedNode == null || selectedNode.Tag == null)
            {
                MessageBox.Show("Please select a directory to copy full path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedDirPath = selectedNode.Tag.ToString();
            Clipboard.SetText(selectedDirPath);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = dirTree.SelectedNode;

            if (selectedNode == null || selectedNode.Tag == null)
            {
                MessageBox.Show("Please select a directory to delete a folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedDirPath = selectedNode.Tag.ToString();
            Directory.Delete(selectedDirPath);
            InitializeDirTree();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = dirTree.SelectedNode;

            if (selectedNode == null || selectedNode.Tag == null)
            {
                MessageBox.Show("Please select a folder to rename.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedDirPath = selectedNode.Tag.ToString();

            NameForm nameForm = new NameForm("", "", selectedDirPath);
            if (nameForm.ShowDialog() == DialogResult.OK)
            {
                string newFolderName = nameForm.Name;

                try
                {
                    string parentDirectory = Path.GetDirectoryName(selectedDirPath);
                    string newFolderPath = Path.Combine(parentDirectory, newFolderName);

                    if (Directory.Exists(newFolderPath))
                    {
                        MessageBox.Show("Folder with the same name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Directory.Move(selectedDirPath, newFolderPath);

                    selectedNode.Text = newFolderName;
                    selectedNode.Tag = newFolderPath;

                    InitializeDirTree();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error renaming the folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TreeNode selectedNode = dirTree.SelectedNode;

            if (selectedNode == null || selectedNode.Tag == null)
            {
                MessageBox.Show("Please select a folder to move.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedDirPath = selectedNode.Tag.ToString();
            NameForm nameForm = new NameForm("", "", selectedDirPath);
            if (nameForm.ShowDialog() == DialogResult.OK)
            {
                string otherFolderName = nameForm.Name;

                try
                {
                    string destinationFolderPath = Path.Combine(selectedDirPath, otherFolderName);

                    if (Directory.Exists(destinationFolderPath))
                    {
                        MessageBox.Show("Folder with the same name already exists in the destination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Directory.Move(selectedDirPath, destinationFolderPath);

                    InitializeDirTree();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error moving the folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

    }
}