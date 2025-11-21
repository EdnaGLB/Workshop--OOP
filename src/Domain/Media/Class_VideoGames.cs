namespace Domain
{
        class VideoGame : Product
    {
        public string genre;
        public string Publisher;
        public int ReleaseYear;
        public string SupportedPlatforms;
        public bool IsCompleted;

        public VideoGame(string title, string genre, string publisher, int releaseYear, string supportedPlatforms)
        {
            base.title = title;
            this.genre = genre;
            this.Publisher = publisher;
            this.ReleaseYear = releaseYear;
            this.SupportedPlatforms = supportedPlatforms;
        }

        public string GetGenre(string Genre)
        {
            this.genre = Genre;
            return Genre;
        }

        public string GetPublisher(string Publisher)
        {
            this.Publisher = Publisher;
            return Publisher;
        }

        public int GetReleaseYear(int ReleaseYear)
        {
            this.ReleaseYear = ReleaseYear;
            return ReleaseYear;
        }

        public string GetSupportedPlatforms(string SupportedPlatforms)
        {
            this.SupportedPlatforms = SupportedPlatforms;
            return SupportedPlatforms;
        }

        public bool GetIsCompleted(bool IsCompleted)
         {
            this.IsCompleted = IsCompleted;
            return IsCompleted;
         }

        public override void Use()
        {
            //Add Code
        }

        public static VideoGame? Parse(string[] args)
        {
            if (args.Length != 23) return null;

            string title = args[2];
            string genre = args[4];
            string publisher = args[13];
            int releaseYear = int.Parse(args[5]);
            string supportedPlatforms = args[14];


            return new VideoGame(title, genre, publisher, releaseYear, supportedPlatforms);
        }
    }
}