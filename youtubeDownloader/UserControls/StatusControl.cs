using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtubeDownloader.UserControls
{
    public partial class StatusControl : UserControl
    {
        public StatusControl()
        {
            InitializeComponent();
        }

        public delegate void UpdateProgress();
        public delegate void Updatelabels(int remain, string title);
        public delegate void UpdateThreadlbl(string txt);

        private static double progressCounter;
        private static double lengthPlaylist;

        private void StatusControl_Load(object sender, EventArgs e)
        {
            progressCounter = 0.0;
            lengthPlaylist = 0.0;
        }

        public void UpdateUI()
        {
            if (bar_download.InvokeRequired)
            {
                bar_download.Invoke(new UpdateProgress(UpdateUI));
            }
            else {
                // create txt or label with remaining jobs in jobs
                int progressValue = Convert.ToInt32((progressCounter / lengthPlaylist) * 100);
                if (progressValue <= 100)
                {
                    bar_download.Value = progressValue;
                }
            }
        }

        public void Updatelbl(int remain, string title) {

            if (lbl_statusControl_remain.InvokeRequired || lbl_statusControl_complete.InvokeRequired)
            {
                lbl_statusControl_remain.Invoke(new Updatelabels(Updatelbl), remain, title);
            }
            else
            {
                lbl_statusControl_remain.Text   = "Remaining:" + remain.ToString();
                lbl_statusControl_complete.Text = "Download Completed: " + title; 
            }
        }

        public void UpdateThreadText(string txt) {
            if (lbl_statusControl_thread.InvokeRequired)
            {
                lbl_statusControl_thread.Invoke(new UpdateThreadlbl(UpdateThreadText), txt);
            }
            else {
                lbl_statusControl_thread.Text = txt;
            }
        }

        /*
         * All the private values are set and get below.
         */

        public void resetProgressCounter() {
            progressCounter = 0;
        }

        public void addProgressCounter() {
            progressCounter++;
        }

        public double getProgressCounter() {
            return progressCounter;
        }

        public void setLengthPlaylist(double x) {
            lengthPlaylist = x;
        }

        public double getLengthPlaylist() {
            return lengthPlaylist;
        }



    }
}
