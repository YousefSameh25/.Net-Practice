namespace Factory_Method___Factory_Abstract
{
    internal class Program
    {
        static void Main()
        {
            PaymentProcessor processor = new PaymentProcessor();

            processor.PaymentProcess(PaymentType.Visa, "Yousef Sameh", "4357546845769", "01/26", "634");

            /*
             The idea of abstract factory:

            Suppose that we have different types of payment methods and can be divided into some groups ex:
            - International cards : Visa, MasterCard.
            - Local cards: Miza.

             1 - We should create an interface IPaymentMethodFactory contains CreatePaymentMethod(PaymentType).
             2 - create for each group a factory class that to create cards of a group.
             3 - PaymentProcessor class must has a IPaymentMethodFactory as a property,
               - the property will be initialized using ctor with the wanted object of factory (new InternationalFactory or new LocalFactory).
             
            Visualized overview:
                                                                      Will deal with:
                             -- IPaymentMethodFactory --   <--------------------------- (PaymentProcessor)


            InternationalPaymentMethodFactory  -  LocalPaymentMethodFactory


                     Visa, MasterCard          -           Miza
             */
        }
    }
}
