using System;
using System.Windows.Forms;
using youtubeDownloader.UserControls;

namespace youtubeDownloader
{
    public partial class Mainform : Form
    {
        UserControl _maincontrol;

        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Start s = new Start();
            pnl_form.Controls.Add(s);
        }

        private void singleVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._maincontrol = new SingleVideoDownload();
            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
            }
            pnl_form.Controls.Add(this._maincontrol);
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._maincontrol = new PlaylistVideoDownload();
            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
            }
            pnl_form.Controls.Add(this._maincontrol);
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._maincontrol = new Configuration(pnl_form);
            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
            }
            pnl_form.Controls.Add(this._maincontrol);
        }

        private void pnl_form_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnl_form.Controls.Count == 0)
            {
                Start s = new Start();
                pnl_form.Controls.Add(s);
            }
        }
    }
}
