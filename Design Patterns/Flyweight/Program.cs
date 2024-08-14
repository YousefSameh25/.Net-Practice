namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             The problem is that we have to create objects that will require memory more than the exist
            so we can put the shared attributed between them in one single object, but make sure that 
            the shared attributes are immutable.

            to build a full general solution we will need a factory for flyweight objects
            with the help of dictionary.
             */

            // Add shared data to cache.
            FactoryFlyweight<CountryWithCity>.AddSharedData(FlyweightType.CountryWithCity, new CountryWithCity
            {
                Country = "Egypt",
                City = "Cairo"
            });

            // Will want here to create 3 customers have same country and city.
            Customer C1 = new Customer(
                1,
                "Yousef",
                FactoryFlyweight<CountryWithCity>.GetSharedData(FlyweightType.CountryWithCity)
            );

            Customer C2 = new Customer(
                2,
                "Moumen",
                FactoryFlyweight<CountryWithCity>.GetSharedData(FlyweightType.CountryWithCity)
            );

            Customer C3 = new Customer(
                3,
                "Ahmed",
                FactoryFlyweight<CountryWithCity>.GetSharedData(FlyweightType.CountryWithCity)
            );

            Customer[] customers = new Customer[3] { C1, C2, C3 };

            foreach (var customer in customers)       
                Console.WriteLine(customer.countryWithCity.Country);

            // Try to edit the in one of them
            customers[0].countryWithCity.Country = "England";

            foreach (var customer in customers)
                Console.WriteLine(customer.countryWithCity.Country);

        }
    }
}
