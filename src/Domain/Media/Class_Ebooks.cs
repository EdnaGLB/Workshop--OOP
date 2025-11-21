using System.Collections;
using System.Diagnostics;

namespace Domain
{
    
class Ebook : Product
    {
        private string author;
        private string language;
        private int numberOfPages;
        private int yearOfPublication;
        private string ISBN;

        public Ebook(string title, string author, string language, 
                        int numberOfPages, int yearOfPublication,
                            string ISBN)
        {
            base.title = title;
            this.author = author;
            this.language = language;
            this.numberOfPages = numberOfPages;
            this.yearOfPublication = yearOfPublication;
            this.ISBN = ISBN;
        }
    
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

        public static Ebook? Parse(string[] args)
        {
            if (args.Length != 23) return null;

            string title = args[2];
            string author = args[3];
            string language = args[7];
            int numberOfPages = int.Parse(args[8])
            int yearOfPublication = int.Parse(args[5]);
            string ISBN = args[6];

            return new Ebook(title, author, language, numberOfPages, yearOfPublication, ISBN);
        }
    }

}