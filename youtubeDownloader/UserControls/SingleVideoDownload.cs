using System;
using System.Windows.Forms;
using youtubeDownloader.Classes;

namespace youtubeDownloader.UserControls
{
    public partial class SingleVideoDownload : UserControl
    {

        public SingleVideoDownload()
        {
            InitializeComponent();
        }

        private async void btn_download_ClickAsync(object sender, EventArgs e)
        {
            string url = txt_url.Text;
            DownloaderClient client = new DownloaderClient();
            string id = client.GetVideoID(url);
            await client.start_downloadAsync(id);
            Download download = client.GetDownload();
            if (download.getError() != string.Empty)
            {
                MessageBox.Show(download.getError());
            }
            else
            {
                UpdateInfoPanel(download.getTitle(), download.getAuthor(), download.getDuration());
            }
        }

        private void UpdateInfoPanel(string title, string author, string duration)
        {
            txt_title.Text = title;
            txt_author.Text = author;
            txt_Duration.Text = duration;
            MessageBox.Show("Download Completed");
        }
    }
}
