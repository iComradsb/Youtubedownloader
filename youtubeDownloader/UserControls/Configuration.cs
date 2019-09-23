using System;
using System.Windows.Forms;

namespace youtubeDownloader.UserControls
{
    public partial class Configuration : UserControl
    {
        Panel p;

        public Configuration(Panel p)
        {
            InitializeComponent();
            txt_selechted_path.Text = (string)LoadSetting("Download_Path");
            this.p = p;
        }

        private void saveSetting(string setting, string value) {
            Properties.Settings.Default[setting] = value;
            Properties.Settings.Default.Save();
        }

        private object LoadSetting(string setting) {
            return Properties.Settings.Default[setting];
        }

        private void btn_pickpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                txt_selechted_path.Text = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show("No folder selected");
            }
        }

        private void btn_savePath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_selechted_path.Text))
            {
                saveSetting("Download_Path", txt_selechted_path.Text);
            }
            p.Controls.RemoveAt(0);
        }
    }
}
