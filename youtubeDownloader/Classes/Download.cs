namespace youtubeDownloader.Classes
{
    class Download
    {
        private int status;
        private string error;
        private string title;
        private string author;
        private string duration;

        public Download(string error, string title, string author, string duration) {
            if (string.IsNullOrEmpty(error))
            {
                this.status     = 1;
                this.error      = "";
                this.title      = title;
                this.author     = author;
                this.duration   = duration;
            }
            else
            {
                this.status = 0;
                this.error = error;
                this.title = title;
                this.author = author;
                this.duration = duration;
            }
        }

        public int getStatus() {
            return this.status;
        }

        public string getError() {
            return this.error;
        }

        public string getTitle() {
            return this.title;
        }

        public string getAuthor() {
            return this.author;
        }

        public string getDuration() {
            return this.duration;
        }
    }
}