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

    public abstract void download();

        
    
    public void use()
        {
            
          // Add code
        }
}
}