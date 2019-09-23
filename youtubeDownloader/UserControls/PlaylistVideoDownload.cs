using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using youtubeDownloader.Classes;

namespace youtubeDownloader.UserControls
{
    public partial class PlaylistVideoDownload : UserControl
    {
        //Globals
        public delegate void UpdateMbox(string txt);
        private List<YoutubeExplode.Models.Video> _jobs;
        Thread _Downloader;
        private string[] _threadStatus;
        private string setting = "Download_Path";
        StatusControl statusgroup;

        public PlaylistVideoDownload()
        {
            InitializeComponent();

            //set status for thread.
            _threadStatus = new string[3];
            _threadStatus[0] = "Create job list";
            _threadStatus[1] = "Downloading Videos";
            _threadStatus[2] = "Done Downloading";

            _jobs = new List<YoutubeExplode.Models.Video>();

            this.statusgroup = new StatusControl();
            pnl_status.Controls.Add(this.statusgroup);
        }

        private void UpdateMboxes(string txt)
        {
            MessageBox.Show(txt);
        }

        public async void OnStartAsync(string url)
        {
            try
            {
                DownloaderClient client = new DownloaderClient();
                await client.Create_joblistAsync(url);
                _jobs = client.getJobs();
                statusgroup.setLengthPlaylist(_jobs.Count);
                statusgroup.UpdateThreadText(_threadStatus[0]);

                if (_jobs.Count == 0)
                {
                    await client.Create_joblistAsync(url);
                    statusgroup.UpdateThreadText(_threadStatus[0]);
                }
                if (statusgroup.getProgressCounter() > 0)
                {
                    statusgroup.resetProgressCounter();
                }

                while (true)
                {
                    if (_jobs.Count > 0)
                    {
                        statusgroup.UpdateThreadText(_threadStatus[1]);
                        var job = _jobs[0];
                        _jobs.RemoveAt(0);
                        await client.start_downloadAsync(job.Id);
                        statusgroup.Updatelbl(_jobs.Count, job.Title);
                        statusgroup.addProgressCounter();
                        statusgroup.UpdateUI();
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                    if (_jobs.Count == 0)
                    {
                        statusgroup.UpdateThreadText(_threadStatus[2]);
                        _Downloader.Abort();
                    }
                }
            }
            catch (Exception ex)
            {
                Mainform main = new Mainform();
                lbl_invoke.Invoke(new UpdateMbox(UpdateMboxes), ex.Message);
            }
        }

        private void btn_playlist_Click(object sender, System.EventArgs e)
        {
            _Downloader = new Thread(delegate () {
                OnStartAsync(txt_playlist.Text);
            });
            _Downloader.Start();
        }
    }
}