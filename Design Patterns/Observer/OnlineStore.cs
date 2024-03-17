using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class OnlineStore
    {
        public Dictionary<EventType, List<ILestenable>> Subscribers { get; set; }
        public List<Product> Products { get; set; }
        public List<Sale> Sales { get; set; }
        public OnlineStore()
        {
            Subscribers = new Dictionary<EventType, List<ILestenable>>();
            initEventTypeLists();
            Products = new List<Product>();
            Sales = new List<Sale>();
        }

        private void initEventTypeLists()
        {
            Subscribers[EventType.NewProductAdded] = new List<ILestenable>();
            Subscribers[EventType.NewSaleAdded] = new List<ILestenable>();
        }

        // Here is the first event
        public void AddProduct(Product P)
        {
            Products.Add(P);

            foreach (ILestenable Lestener in Subscribers[EventType.NewProductAdded])
                Lestener.Notify($"A new product: {P.Name} has been added!");
        }
        // Here is the second event
        public void AddSale(Sale S)
        {
            Sales.Add(S);

            foreach (ILestenable Lestener in Subscribers[EventType.NewSaleAdded])
                Lestener.Notify($"There is a new sale: {S.SaleMessage}");
        }

        public void Subscribe(EventType eventType, ILestenable Lestener)
        {
            Subscribers[eventType].Add(Lestener);
        }

        public void Unsubscribe(EventType eventType, ILestenable Lestener)
        {
            Subscribers[eventType].Remove(Lestener);
        }

    }
}
