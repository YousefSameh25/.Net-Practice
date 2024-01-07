using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Magazine
    {
        public string Name { get; set; }

        // Handle event.
        public void GetNotificationForMagazine(object publisher, EventArgs data)
        {
            AdditionalData AD = (AdditionalData)data;
            Console.WriteLine($"The Journalist {AD.Journalist} has written:");
            Console.WriteLine(AD.Data);
        }
    }
}
