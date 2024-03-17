using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class TextEditor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public TextEditorState Save()
        {
            TextEditorState state = new TextEditorState
            {
                Name = Name,
                Age = Age,
            };
            return state;
        }

        public void Restore(TextEditorState State)
        {
            Name = State.Name;
            Age = State.Age;
        }
    }
}
