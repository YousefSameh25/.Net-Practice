using Exam_CS_OOP_.QuestionComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CS_OOP_.ExamComponent
{
    internal class PracticeExam : Exam
    {
        public override void CreateExam()
        {
            Console.WriteLine("===================(Creating practice exam)===================");
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
            Questions = new List<Question>();
            for (int i = 0; i < QuestionsNumber; i++)
                Questions.Add(QuestionMCQ.CreateQuestionMCQ());
        }

        public override void ResultOfExam(int CollectedMarks, List<string> answers)
        {
            int totalMarks = 0;
            Console.WriteLine("The right answers are:");
            for (int i = 0; i < QuestionsNumber; i++)
            {
                QuestionMCQ Q = Questions[i] as QuestionMCQ;
                Console.WriteLine($"Q{i + 1}) {Questions[i].Body}. Right Answer: {Q.RightAnswer.ChoiceAnswer}");
                totalMarks += Q.Mark;
            }

            Console.WriteLine($"You have got {CollectedMarks}/{totalMarks}");
            Console.WriteLine("===================================================");
        }
    }
}
