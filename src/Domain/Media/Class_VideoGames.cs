namespace Domain
{
    class VideoGame : Product
{
    public string genre;
    public string Publisher;
    public int ReleaseYear;
    public string SupportedPlatforms;
    public bool IsCompleted;

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
}
}