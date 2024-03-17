using Observer.Lesteners;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineStore onlineStore = new OnlineStore();

            // Create 2 types of lesteners
            Customer customer = new Customer { Name = "Yousef" };
            Company company = new Company { Name = "Google" };

            // Subscribing
            onlineStore.Subscribe(EventType.NewProductAdded, customer);
            onlineStore.Subscribe(EventType.NewSaleAdded, customer);
            onlineStore.Subscribe(EventType.NewProductAdded, company);

            // Event occuring
            onlineStore.AddProduct(new Product { Name = "Iphone 14" });
            onlineStore.AddSale(new Sale { SaleMessage = "30% discount for any product" });

            // Unsubscribing
            onlineStore.Unsubscribe(EventType.NewProductAdded, company);

            // Event occuring
            onlineStore.AddProduct(new Product { Name = "Iphone 15" });
        }
    }
}
