namespace Domain
{
  class Podcast : Product
{
    public int ReleaseYear;
    public string Hosts;
    public string Guests;
    public int EpisodeNumber;
    public string Language;
    public bool IsCompleted;

     public int GetReleaseYear(int ReleaseYear)
        {
            this.ReleaseYear = ReleaseYear;
            return ReleaseYear;
        }
     public string GetHosts(string Hosts)
        {
            this.Hosts = Hosts;
            return Hosts;
        }
     public string GetGuests(string Guests)
        {
            this.Guests = Guests;
            return Guests;
        }
     public int GetEpisodeNumber(int EpisodeNumber)
        {
            this.EpisodeNumber = EpisodeNumber;
            return EpisodeNumber;
        }
     public string GetLanguage(string Language)
        {
            this.Language = Language;
            return Language;
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