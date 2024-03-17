using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_CS_OOP_.AnswerComponent;

namespace Exam_CS_OOP_.QuestionComponent
{
    internal class QuestionMCQ : Question
    {
        public AnswerMCQ RightAnswer { get; set; }
        public AnswerMCQ[] AnswerMCQ { get; set; }


        public QuestionMCQ(string Header, string Body, ushort Mark, AnswerMCQ[] AnswerMCQ,
            AnswerMCQ RightAnswer) : base(Header, Body, Mark)
        {
            this.AnswerMCQ = AnswerMCQ;
            this.RightAnswer = RightAnswer;
        }

        internal override void Show()
        {
            Console.WriteLine(base.Body);
            for (int i = 0; i < AnswerMCQ.Length; i++)
                Console.WriteLine($"{i + 1}) {AnswerMCQ[i].ChoiceAnswer}");
        }
        internal override int Check(ref List<string> Enteredanswers)
        {
            bool valid = false;
            int Enteredanswer;
            do
            {
                Console.Write("Enter the choice number: ");
                valid = int.TryParse(Console.ReadLine(), out Enteredanswer);
            }
            while (!valid);

            Console.WriteLine("----------------------------------------");
            Enteredanswers.Add(AnswerMCQ[Enteredanswer].ChoiceAnswer);
            if (AnswerMCQ[Enteredanswer].ChoiceAnswer == RightAnswer.ChoiceAnswer)
                return Mark;
            return 0;
        }

        public static QuestionMCQ CreateQuestionMCQ()
        {
            QuestionMCQ Q = null;

            Console.Write("Enter the mcq question: ");
            string body = Console.ReadLine();
            Console.Write("Enter the mark of the mcq question: ");
            ushort mark = ushort.Parse(Console.ReadLine());
            AnswerMCQ[] answer = new AnswerMCQ[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter ({i + 1}) choice:");
                string choice = Console.ReadLine();
                answer[i] = new AnswerMCQ(i + 1, choice);
            }

            Console.Write("Enter the number of the correct answer: ");
            int idxRightAnswer = int.Parse(Console.ReadLine());
            AnswerMCQ correctAnswer = answer[idxRightAnswer - 1];

            Q = new QuestionMCQ("(MCQ question)", body, mark, answer, correctAnswer);
            return Q;
        }

    }
}
