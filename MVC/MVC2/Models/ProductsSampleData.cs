namespace MVC2.Models
{
    public class ProductsSampleData
    {
        private List<Product> products;
        public ProductsSampleData()
        {
            products = new List<Product>
            {
                new Product { ID = 1 , Name = "IPhone" , Price = 40000, Description = "IPhone 14 pro 256 GB", Image = "1.jpeg"},
                new Product { ID = 2 , Name = "Samsung" , Price = 35000, Description = "Samsung s23 ultra 256 GB", Image = "2.jpeg"},
                new Product { ID = 3 , Name = "Oppo" , Price = 25000, Description = "Oppo reno 2f 256 GB", Image = "3.jpeg"},
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int id)
        {
            return products.SingleOrDefault(p => p.ID == id);
        }

    }
}
