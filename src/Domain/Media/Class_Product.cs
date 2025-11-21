namespace Domain
{
abstract class Product
{
    private string title;

    public string GetTitle(string title)
        {
            this.title = title;
            return title;
        }

    public void download()
        {
            Console.WriteLine("Downloading of " + title + " is completed.");
        }

        
    
    public abstract void Use();
       
}
}