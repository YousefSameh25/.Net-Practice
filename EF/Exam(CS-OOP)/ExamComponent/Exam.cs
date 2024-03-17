using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_CS_OOP_.QuestionComponent;

namespace Exam_CS_OOP_.ExamComponent
{
    internal abstract class Exam
    {
        private protected List<Question> Questions;
        public int QuestionsNumber { get; set; }
        public int ExamTime { get; set; }

        public void ShowExam()
        {
            Console.WriteLine("==================(Exam)===================");
            int CollectedMarks = 0, totalMarks = 0;
            List<string> Enteredanswers = new List<string>();
            for (int i = 0; i < QuestionsNumber; i++)
            {
                Console.Write($"Question ({i + 1}) {Questions[i].Header}     Marks: {Questions[i].Mark} \n");
                Questions[i].Show();
                CollectedMarks += Questions[i].Check(ref Enteredanswers);
                totalMarks += Questions[i].Mark;
            }
            ResultOfExam(CollectedMarks, Enteredanswers);
        }

        public abstract void CreateExam();
        public abstract void ResultOfExam(int CollectedMarks, List<string> answers);

    }
}
