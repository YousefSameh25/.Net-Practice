using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;

namespace Observer.Lesteners
{
    internal class Customer : ILestenable
    {
        public string Name { get; set; }
        public void Notify(string messege)
        {
            Console.WriteLine($"Customer: {Name} has recieved '{messege}'");
        }
    }
}
