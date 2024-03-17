using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class TextEditorStateManagementService
    {
        private List<TextEditorState> textEditorStates;
        private int CurrentStateIdx;

        public TextEditorStateManagementService()
        {
            CurrentStateIdx = -1;
            textEditorStates = new List<TextEditorState>();
        }
        public void SaveState(TextEditorState state)
        {
            textEditorStates.Add(state);
            CurrentStateIdx++;
        }

        public TextEditorState Undo()
        {
            // If there is no previous state return the current state.
            if (CurrentStateIdx - 1 < 0)
                return textEditorStates[CurrentStateIdx];

            return textEditorStates[--CurrentStateIdx];
        }

        public TextEditorState Redo()
        {
            // If there is no next state return the current state.
            if (CurrentStateIdx + 1 >= textEditorStates.Count)
                return textEditorStates[CurrentStateIdx];

            return textEditorStates[++CurrentStateIdx];
        }
    }
}
