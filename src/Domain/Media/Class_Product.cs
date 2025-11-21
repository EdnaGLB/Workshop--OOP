namespace Domain
{
    public abstract class Product
    {
        public string title;

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

        public static Product? Parse(String product)
        {
            string[] fields = product.Split(",");

            string type = fields[0];

            switch (type)
            {
                case "EBook":
                    return Ebook.Parse(fields);
                case "VideoGame":
                    return VideoGame.Parse(fields);
            }
        }
       
    }
}