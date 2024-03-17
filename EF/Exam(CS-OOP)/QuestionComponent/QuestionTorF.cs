using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_CS_OOP_.AnswerComponent;
using Exam_CS_OOP_.QuestionComponent;

namespace Exam_CS_OOP_.QuestionComponent
{
    internal class QuestionTorF : Question
    {
        public bool RightAnswer { get; set; }

        public QuestionTorF(string Header, string Body, ushort Mark, bool RightAnswer) : base(Header, Body, Mark)
        {
            this.RightAnswer = RightAnswer;
        }

        internal override void Show()
        {
            Console.WriteLine(base.Body);
        }

        internal override int Check(ref List<string> Enteredanswers)
        {
            bool valid = false;
            bool EnteredAnswer;
            do
            {
                Console.Write("Enter 'true' or 'false': ");
                valid = bool.TryParse(Console.ReadLine(), out EnteredAnswer);
            }
            while (!valid);
            Console.WriteLine("----------------------------------------");
            Enteredanswers.Add(EnteredAnswer.ToString());
            if (EnteredAnswer == RightAnswer)
                return Mark;
            return 0;
        }


        public static QuestionTorF CreateQuestionTorF()
        {
            QuestionTorF Q = null;

            Console.Write("Enter the True or False question: ");
            string body = Console.ReadLine();
            Console.Write("Enter the mark of the True or False question: ");
            ushort mark = ushort.Parse(Console.ReadLine());

            bool rightAnswer;
            Console.Write("Enter the right answer ('True' or 'False'): ");
            rightAnswer = bool.Parse(Console.ReadLine());
            Q = new QuestionTorF("(True or False)", body, mark, rightAnswer);
            return Q;
        }
    }
}
