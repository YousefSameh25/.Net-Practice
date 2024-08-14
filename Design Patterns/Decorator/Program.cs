namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Suppose we have different types of beverages ex (Tea, Coffee).

             with many extra things ex(Milk, Sugar, Lemon).

             Our logic is that:
             1- we can not add a beverage to another beverage.
             2- we can add any extra to any beverage any number of times.
             
             */

            DecoratorExtras lemon = new Lemon();
            lemon.Cost = 5;

            DecoratorExtras milk = new Milk(lemon);
            milk.Cost = 10;

            DecoratorExtras sugar = new Sugar(milk);
            sugar.Cost = 2;

            Beverage tea = new Tea(sugar);
            tea.Cost = 7;

            tea.Prepare();

            Console.WriteLine(tea.Cost);

        }
    }
}
