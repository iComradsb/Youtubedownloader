using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//Youtube class.
using YoutubeExplode;
using YoutubeExplode.Models;
using YoutubeExplode.Models.MediaStreams;

namespace youtubeDownloader.Classes
{
    class DownloaderClient
    {
        // private jobs list
        private List<Video> _jobs;
        private Download download;
        private string setting = "Download_Path";

        public DownloaderClient()
        {
            _jobs = new List<Video>();
         }

        public string GetVideoID(string url) {
            string id = YoutubeClient.ParseVideoId(url);
            return id;
        }

        public async Task Create_joblistAsync(string url)
        {
            string id = YoutubeClient.ParsePlaylistId(url);
             var client = new YoutubeClient();

            Playlist playlist = await client.GetPlaylistAsync(id);
            var videos = playlist.Videos;
              
            foreach (Video item in videos)
            {
                _jobs.Add(item);
            }
         }

        public async Task start_downloadAsync(string id)
        {
            var client = new YoutubeClient();

            var video = await client.GetVideoAsync(id);
            UrlParser parser = new UrlParser(video.Title);
            string path = (string)Properties.Settings.Default[setting];

            try
            {
                // Get metadata for all streams in this video
                var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(id);

                // ...or highest bitrate audio stream
                var streamInfo = streamInfoSet.Audio.WithHighestBitrate();

                // Get file extension based on stream's container
                var ext = streamInfo.Container.GetFileExtension();

                await client.DownloadMediaStreamAsync(streamInfo,
                    $"{path}//{parser.getUrl()}.mp3");
                download = new Download("", video.Title, video.Author, video.Duration.ToString());
            }
            catch (Exception exc)
            {
                download = new Download(exc.Message, "", "", "");
            }
        }

        //the getters
        public List<Video> getJobs() {
            return this._jobs;
        }

        public Download GetDownload() {
            return download;
        }
    }
}