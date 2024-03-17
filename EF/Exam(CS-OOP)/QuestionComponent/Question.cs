using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CS_OOP_.QuestionComponent
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public ushort Mark { get; set; }


        public Question(string Header = "No header", string Body = "No body", ushort Mark = 0)
        {
            this.Header = Header;
            this.Body = Body;
            this.Mark = Mark > 0 ? Mark : (ushort)0; // Marks can not be a negative value.
        }

        internal abstract void Show();
        internal abstract int Check(ref List<string> Enteredanswers);
    }
}
