namespace Domain
{
    class Image : Product
{
    public string Resolution;
    public string FileFormat;
    public double FileSize;
    public string DateTaken;

     public string GetResolution(string Resolution)
        {
            this.Resolution = Resolution;
            return Resolution;
        }
     public string GetFileFormat(string FileFormat)
        {
            this.FileFormat = FileFormat;
            return FileFormat;
        }
    
    public double GetFileSize(double FileSize)
        {
            this.FileSize = FileSize;
            return FileSize;
        }
     public string GetDateTaken(string DateTaken)
        {
            this.DateTaken = DateTaken;
            return DateTaken;
        }
         public override void Use()
        {
            //Add Code
        }

}  
}