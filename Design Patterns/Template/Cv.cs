using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal abstract class Cv
    {
        // This function will be the same for the children classes
        public CvFromPath ReadCv(string CvPath)
        {
            Console.WriteLine($"Reading Cv from {CvPath}");
            return new CvFromPath();
        }

        // This function will has a different implementation from any child to another.
        public abstract void GenerateCvReport(CvFromPath cvFromPath);
    }
}
