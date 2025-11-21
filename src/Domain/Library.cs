using System.Runtime.InteropServices;
using Data;

namespace Domain
{
    public class Library
    {
        public List<Product> products = new();

        public Library(List<Product> products)
        {
            this.products = products;
        }

        public Library()
        {
            this.products = new List<Product>();
        }

        public bool Load(string filename)
        {
            FileBackEnd fb = new(filename);

            if (fb == null) return false;

            List<string> entries = fb.Load();

            if (entries == null) return false;

            foreach(String row in entries)
            {
                Product? product = Product.Parse(row);

                if (product != null) AddProduct(product);
            }
        }

        public void AddProduct(Product product)
        {
            if (!products.Contains(product))
            {
                products.Add(product);
            }
        }
    }
}
