namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // one disavdantage of Facade is the object might be god object.
            FlightFacade flight = new FlightFacade(
                new PaymentProcessing(),
                new CarRental(),
                new HotelReservation(),
                new FlightManagement()
            );

            // Set Attributes
            flight._FlightManagement.FlightClass = 1;
            flight._CarRental.CarId = 1;
            flight._HotelReservation.RoomId = 1;
            flight._PaymentProcessing.Cost = 10000;


            flight.ProcessFlight();
        }
    }
}
