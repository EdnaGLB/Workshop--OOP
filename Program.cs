// See https://aka.ms/new-console-template for more information
namespace Classes_Items
{
    class Product
    {
        private string title; 

        public string GetTitle()
        {
            return this.title;
        }

        public void download()
        {
            //Add code
        } 

        public useItem()
        {
            //Add code
        }
    }

    class Ebook : Product
    {
        private string author; 
        private string language;
        private int numberOfPages;
        private int yearOfPublication;
        private string ISBN;

        public string GetAuthor()
        {
            return this.author;

        }

        public string Getlanguage()
        {
            return this.language;

        }

        public int GetNumberOfPages()
        {
            return this.numberOfPages;

        }
        public int GetYearOfPublication()
        {
            return this.yearOfPublication;

        }

        public string GetISBN()
        {
            return this.ISBN;

        }


    }
}