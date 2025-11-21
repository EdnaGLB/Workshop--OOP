namespace Domain 
{
class App : Product
{
    public string Version;
    public string Publisher;
    public string SupportedPlatforms;
    public double FileSize;

     public string GetVersion(string Version)
        {
            this.Version = Version;
            return Version;
        }
      public string GetPublisher(string Publisher)
        {
            this.Publisher = Publisher;
            return Publisher;
        }
      public string GetSupportedPlatforms(string SupportedPlatforms)
        {
            this.SupportedPlatforms = SupportedPlatforms;
            return SupportedPlatforms;
        }
      public double GetFileSize(double FileSize)
        {
            this.FileSize = FileSize;
            return FileSize;
        }
    public override void Use()
        {
            //Add Code
        }

    
}
}



