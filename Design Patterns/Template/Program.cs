using Template.CvTypes;

namespace Template
{
    internal class Program
    {
        static void Main()
        {
            GenerateCvReportService generatedCvReport = new GenerateCvReportService(new PdfCv());
            generatedCvReport.GenerateCvReport();

            generatedCvReport = new GenerateCvReportService(new ImageCv());
            generatedCvReport.GenerateCvReport();
        }
    }
}
