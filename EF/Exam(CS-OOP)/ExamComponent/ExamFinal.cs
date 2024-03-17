using Exam_CS_OOP_.QuestionComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CS_OOP_.ExamComponent
{
    internal class ExamFinal : Exam
    {
        public override void CreateExam()
        {
            Console.WriteLine("===================(Creating final exam)===================");
            bool valid = false;
            int questionsNumber;
            do
            {
                Console.Write("Enter exam number of questions: ");
                valid = int.TryParse(Console.ReadLine(), out questionsNumber);
            }
            while (!valid);
            QuestionsNumber = questionsNumber;

            valid = false;
            int examTime;
            do
            {
                Console.Write("Enter exam time in minutes: ");
                valid = int.TryParse(Console.ReadLine(), out examTime);
            }
            while (!valid);
            ExamTime = examTime;
            Console.WriteLine("-----------------------------------------");
            Questions = new List<Question>();
            for (int i = 0; i < QuestionsNumber; i++)
            {
                valid = false;
                int QuestionType;
                do
                {
                    Console.Write($"Enter question({i + 1}) type number (1-True or false " +
                        "2-MCQ): ");
                    valid = int.TryParse(Console.ReadLine(), out QuestionType);
                }
                while (!valid || (QuestionType != 1 && QuestionType != 2));

                if (QuestionType == 2)
                    Questions.Add(QuestionMCQ.CreateQuestionMCQ());
                else
                    Questions.Add(QuestionTorF.CreateQuestionTorF());
                Console.WriteLine("-----------------------------------------");
            }
        }

        public override void ResultOfExam(int CollectedMarks, List<string> answers)
        {
            int totalMarks = 0;
            Console.WriteLine("Your answers are:");
            for (int i = 0; i < QuestionsNumber; i++)
            {
                Console.WriteLine($"Q{i + 1}) {Questions[i].Body}. Your Answer: {answers[i]}");
                totalMarks += Questions[i].Mark;
            }

            Console.WriteLine($"You have got {CollectedMarks}/{totalMarks}");
            Console.WriteLine("===================================================");
        }
    }
}
