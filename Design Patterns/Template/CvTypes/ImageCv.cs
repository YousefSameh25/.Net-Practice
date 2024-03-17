using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.CvTypes
{
    internal class ImageCv : Cv
    {
        public override void GenerateCvReport(CvFromPath cvFromPath)
        {
            Console.WriteLine("Generate CV Report for Image CV!");
        }
    }
}
