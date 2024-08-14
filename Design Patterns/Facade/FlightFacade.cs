using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class FlightFacade
    {
        public PaymentProcessing _PaymentProcessing { get; set; }
        public CarRental _CarRental { get; set; }
        public HotelReservation _HotelReservation { get; set; }
        public FlightManagement _FlightManagement { get; set; }

        public FlightFacade (PaymentProcessing PaymentProcessing, CarRental CarRental, 
            HotelReservation HotelReservation, FlightManagement FlightManagement) {
            this._PaymentProcessing = PaymentProcessing;
            this._CarRental = CarRental;    
            this._HotelReservation = HotelReservation;
            this._FlightManagement = FlightManagement;
        }

        public void ProcessFlight ()
        {
            _FlightManagement.ReserveFlight();
            _HotelReservation.ReserveRoom();
            _CarRental.RentCar();
            _PaymentProcessing.PaymentProcess();
        }

    }
}
