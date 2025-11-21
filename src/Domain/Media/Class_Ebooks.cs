namespace Domain
{
    
class Ebook : Product
    {
        private string author;
        private string language;
        private int numberOfPages;
        private int yearOfPublication;
        private string ISBN;
    
        public string GetAuthor(string author)
        {
            this.author = author;
            return author;
        }
    
        public string GetLanguage(string language)
        {
            this.language = language;
            return language;
        }

        public int GetNumberOfPages(int NumberOfPages)
        {
            this.numberOfPages = NumberOfPages;
            return NumberOfPages;
        }

        public int GetYearOfPublication(int YearOfPublication)
        {
            this.yearOfPublication = YearOfPublication;
            return YearOfPublication;
        }

        public string GetISBN(string ISBN)
        {
            this.ISBN = ISBN;
            return ISBN;
        }

        public override void Use()
        {
            //Add Code
        }

    }

}