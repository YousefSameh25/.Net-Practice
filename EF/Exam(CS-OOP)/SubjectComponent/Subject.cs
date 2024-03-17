using Exam_CS_OOP_.ExamComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CS_OOP_.SubjectComponent
{
    internal class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }



        public Subject(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }


        public void CreateExam()
        {
            int type;
            Console.Write("Enter the exam type number (1-Final exam. 2-Practice exam): ");
            type = int.Parse(Console.ReadLine());

            Exam e;
            if (type == 1)
                Exam = new ExamFinal();
            else
                Exam = new PracticeExam();

            Exam.CreateExam();
        }
    }
}
