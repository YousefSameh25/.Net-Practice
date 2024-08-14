using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Quality1 : IQuality
    {
        public void Render()
        {
            Console.WriteLine("Video is rendering in quality 2");
        }
    }
}
