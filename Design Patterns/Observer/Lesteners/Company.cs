using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;

namespace Observer.Lesteners
{
    internal class Company : ILestenable
    {
        public string Name { get; set; }
        public void Notify(string messege)
        {
            Console.WriteLine($"Company: {Name} has recieved '{messege}'");
        }
    }
}
