using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HotelReservation
    {
        public int RoomId { get; set; }
        public void ReserveRoom()
        {
            Console.WriteLine($"Reserving room {RoomId}");
        }
    }
}
