using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Person
    {
        public string Name { get; set; }

        // Handle event.
        public void GetNotification(object publisher, EventArgs data)
        {
            AdditionalData AD = (AdditionalData)data;
            Console.WriteLine($"The Journalist {AD.Journalist} has written:");
            Console.WriteLine(AD.Data);
        }
    }
}
