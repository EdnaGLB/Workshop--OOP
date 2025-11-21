namespace Domain
{
    class Borrower : User
{


    public void SortCollection()
    {
       //???
    }

    public void ShowDetails()
    {
        foreach (var item in Collection)
        {
            Console.WriteLine();
        }
    }

    public void RateItem(Product product, int rating)
    {
        Console.WriteLine();
    }
}
}