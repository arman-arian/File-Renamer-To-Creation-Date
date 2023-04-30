using System;
using System.IO;
using System.Windows.Forms;

namespace FileRenamerToCreationDate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            fbdBrowser.ShowNewFolderButton = false;

            var dialog = fbdBrowser.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                txtFilePath.Text = fbdBrowser.SelectedPath;
            }
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            var dirPath = txtFilePath.Text;
            if (string.IsNullOrEmpty(dirPath))
            {
                MessageBox.Show(@"Directory path is empty");
                return;
            }

            if (Directory.Exists(dirPath) == false)
            {
                MessageBox.Show(@"Directory path is not exists");
                return;
            }

            var files = Directory.GetFiles(dirPath);
            if (files.Length <= 0)
            {
                MessageBox.Show(@"No files found");
                return;
            }

            foreach (var file in files)
            {
                if (string.IsNullOrEmpty(file))
                    continue;

                try
                {
                    using (var renamer = new FileRenamer(file, chkLastWriteTime.Checked, chkExif.Checked))
                    {
                        renamer.Rename();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Path: {file} - Error: {ex.Message}");
                }
            }
        }
    }
}