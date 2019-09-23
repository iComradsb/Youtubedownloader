namespace youtubeDownloader.Classes
{
    class UrlParser
    {
        private string url;
        public UrlParser(string url)
        {

            if (url.Contains(":"))
            {
                url = url.Replace(":", "-");
            }
            if (url.Contains("|"))
            {
                url = url.Replace("|", "-");
            }
            if (url.Contains("[") & url.Contains("]"))
            {
                url = url.Replace("[", "(");
                url = url.Replace("]", ")");
            }
            if (url.Contains("\""))
            {
                url = url.Replace("\"", "");
            }
            this.url = url;
        }

        public string getUrl() {
            return url;
        }
    }
}
