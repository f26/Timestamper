using System.Windows.Forms;

namespace Timestamper
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxFormat.SelectedIndex = 0;
            FormMain_Resize(null, null);
            textBoxPath_TextChanged(null, null);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            olv.Width = this.ClientSize.Width - olv.Left * 2;
            olv.Height = this.ClientSize.Height - olv.Top - olv.Left;
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        private void RefreshFiles()
        {
            olv.Items.Clear();
            if (!Directory.Exists(textBoxPath.Text)) return;
            Dictionary<string, string> newNames = new Dictionary<string, string>();

            List<FileItem> items = new List<FileItem>();
            DirectoryInfo dinfo = new DirectoryInfo(textBoxPath.Text);
            foreach (FileInfo finfo in dinfo.GetFiles())
            {
                DateTime time = finfo.LastWriteTime;
                if (radioButtonCreationTime.Checked) time = finfo.CreationTime;

                // Determine new name.  If a conflict exists, add +1 sec to new name until it is deconflicted
                // This checks for a conflict on proposed names as well as on already-existing files in the parent directory
                string newname = time.ToString(comboBoxFormat.Text) + finfo.Extension;
                uint count = 1;
                while (newNames.ContainsKey(newname) || File.Exists(Path.GetDirectoryName(finfo.FullName) + "\\" + newname))
                {
                    newname = time.AddSeconds(count).ToString(comboBoxFormat.Text) + finfo.Extension;
                    count++;
                }
                newNames.Add(newname, newname);
                items.Add(new FileItem(finfo, newname));
            }

            olv.SetObjects(items);
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            olv.Enabled = buttonRename.Enabled = textBoxPath.Enabled = false;
            Application.DoEvents();

            try
            {
                foreach (FileItem item in olv.Objects.Cast<FileItem>().ToList())
                {
                    if (item.FullName() != item.FullNewName())
                        File.Move(item.FullName(), item.FullNewName());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while renaming: " + ex.ToString());
            }

            RefreshFiles();
            olv.Enabled = buttonRename.Enabled = textBoxPath.Enabled = true;
        }

        private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        private void textBoxPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            buttonRename_Click(null, null);
        }

        private void radioButtonModificationTime_CheckedChanged(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        private void radioButtonCreationTime_CheckedChanged(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshFiles();
        }
    }
}