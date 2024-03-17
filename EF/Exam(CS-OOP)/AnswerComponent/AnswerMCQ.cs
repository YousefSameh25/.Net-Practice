namespace Exam_CS_OOP_.AnswerComponent
{
    internal class AnswerMCQ
    {
        public int ChoiceID { get; set; }
        public string ChoiceAnswer { get; set; }
        public AnswerMCQ(int ChoiceID, string Choice = "Empty choice")
        {
            this.ChoiceID = ChoiceID;
            ChoiceAnswer = Choice;
        }
    }
}