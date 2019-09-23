using System;
using System.Windows.Forms;

// used for the downnload 
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
using YoutubeExplode.Models;

// threadpool.
using System.Threading;
using System.Collections.Generic;

//using own code
using youtubeDownloader.Classes;
using youtubeDownloader.UserControls;

namespace youtubeDownloader
{
    public partial class Mainform : Form
    {
        public delegate void UpdateMbox(string txt);

        private List<Video> _jobs;
        Thread _Downloader;
        private string[] _threadStatus;

        //loaded user controls in mainform.
        StatusControl statusgroup;

        public Mainform()
        {
            InitializeComponent();

            //set status for thread.
            _threadStatus = new string[3];
            _threadStatus[0] = "Create job list";
            _threadStatus[1] = "Downloading Videos";
            _threadStatus[2] = "Done Downloading";

            _jobs = new List<Video>();

            this.statusgroup = new StatusControl();
            pnl_status.Controls.Add(this.statusgroup);

        }

        public void Enqueue(Video job)
        {
            _jobs.Add(job);
        }

        public void OnStart()
        {
            if (_jobs.Count == 0) {
                Create_joblist(txt_playlist.Text);
                statusgroup.UpdateThreadText(_threadStatus[0]);
            }
            if (statusgroup.getProgressCounter() > 0) {
                statusgroup.resetProgressCounter();
            }
            
            while (true)
            {
                if (_jobs.Count > 0)
                {
                    statusgroup.UpdateThreadText(_threadStatus[1]);
                    var job = _jobs[0];
                    _jobs.RemoveAt(0);
                    start_downloadAsync(job.Id);
                    statusgroup.Updatelbl(_jobs.Count, job.Title);
                    statusgroup.addProgressCounter(); 
                    statusgroup.UpdateUI();
                    Thread.Sleep(1000);
                }
                else {
                    Thread.Sleep(1000);
                }
                if (_jobs.Count == 0)
                {
                    statusgroup.UpdateThreadText(_threadStatus[2]);
                    _Downloader.Abort();
                }
            }
        }

        private void UpdateMboxes(string txt) {
            MessageBox.Show(txt);
        }

        private async void Create_joblist(string url) {

            string id = YoutubeClient.ParsePlaylistId(url);
            var client = new YoutubeClient();

            var playlist = await client.GetPlaylistAsync(id);
            var videos = playlist.Videos;
            statusgroup.setLengthPlaylist(playlist.Videos.Count);

            foreach (Video item in videos)
            {
                Enqueue(item);
            }
            
        }

        private void UpdateInfoPanel(string title, string author, string duration) {
            txt_title.Text      = title;
            txt_author.Text     = author;
            txt_Duration.Text   = duration;
        }

        private async void start_downloadAsync(string id) {

            var client = new YoutubeClient();

            var video = await client.GetVideoAsync(id);
            string title = video.Title.ToString();
            if (title.Contains(":"))
            {
                title = title.Replace(":", "-");
            }
            if (title.Contains("|"))
            {
                title = title.Replace("|", "-");
            }
            if (title.Contains("[") & title.Contains("]"))
            {
                title = title.Replace("[", "(");
                title = title.Replace("]", ")");
            }
            if (title.Contains("\""))
            {
                title = title.Replace("\"", "");
            }
            
            try
            {
                // Get metadata for all streams in this video
                var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(id);

                // ...or highest bitrate audio stream
                var streamInfo = streamInfoSet.Audio.WithHighestBitrate();

                // Get file extension based on stream's container
                var ext = streamInfo.Container.GetFileExtension();

                await client.DownloadMediaStreamAsync(streamInfo,
                    $"C://Test//{title}.mp3");
                
            }
            catch (Exception exc){
                //bar_download.Invoke(new UpdateMbox(UpdateMboxes), exc.Message);
            }
         }


        private void btn_download_Click(object sender, EventArgs e)
        {
            string url = txt_url.Text;
            string id = YoutubeClient.ParseVideoId(url); // get everthing after = in the url.


            start_downloadAsync(id);

        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            //Create_joblist(txt_playlist.Text);
            _Downloader = new Thread(delegate () {
                    OnStart();
                });
            _Downloader.Start();
        }

        private void singleVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
