using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class StreamProvider1
    {
        private readonly IQuality quality;
        public StreamProvider1(IQuality quality)
        {
            this.quality = quality;
        }

        public void PlayBack()
        {
            quality.Render();
            Console.WriteLine("Video is playing now!");
        }

    }
}
