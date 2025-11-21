namespace Domain
{
    class Movies : Product
    {
        private string director;
        string[] genres = new string[5];
        private int releaseYear;
        private string language;
        private double duration;

        public string GetDirector(string Director)
        {
            this.director = Director;
            return Director;
        }
        public int GetreleaseYear(int releaseYear)
        {
            this.releaseYear = releaseYear;
            return releaseYear;
        }

        public string Getlanguage(string language)
        {
            this.language = language;
            return language;
        }

        public double GetDuration(double duration)
        {
            this.duration = duration;
            return duration;
        }

        public void GetGenere()
        {
            foreach ( string g in genres)
            {
                Console.Write(g);
            }
        }

         public override void Use()
        {
            //Add Code
        }

    }
}