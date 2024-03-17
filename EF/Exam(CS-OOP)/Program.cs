using Exam_CS_OOP_.SubjectComponent;
using System.Diagnostics;

namespace Exam_CS_OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10, "C#");
            sub.CreateExam();
            Console.Write("Do you want to solve the exam (y/n)?: ");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Stopwatch sw = Stopwatch.StartNew();
                sub.Exam.ShowExam();
                sw.Stop();

                Console.WriteLine($"Total taken time in seconds: {sw.Elapsed.TotalSeconds}");
            }
        }
    }
}
