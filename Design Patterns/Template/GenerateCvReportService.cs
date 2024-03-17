using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class GenerateCvReportService
    {
        public Cv cv;
        public GenerateCvReportService(Cv cv)
        {
            this.cv = cv;
        }

        public void GenerateCvReport()
        {
            cv.GenerateCvReport(cv.ReadCv("yousef\\cv"));
        }
    }
}
