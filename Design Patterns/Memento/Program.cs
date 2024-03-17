namespace Memento
{
    internal class Program
    {
        static void Main()
        {
            // We can resuse TextEditorStateManagementService by converting it to a generic class.
            TextEditorStateManagementService History = new TextEditorStateManagementService();
            TextEditor editor = new TextEditor();

            editor.Name = "Yosuef";
            editor.Age = 20;
            History.SaveState(editor.Save());

            Console.WriteLine($"Name: {editor.Name}, Age: {editor.Age}");

            //-------------------------------

            editor.Name = "Magdy";
            editor.Age = 21;
            History.SaveState(editor.Save());

            Console.WriteLine($"Name: {editor.Name}, Age: {editor.Age}");

            //-------------------------------

            editor.Restore(History.Undo());
            Console.WriteLine($"Name: {editor.Name}, Age: {editor.Age}");

            //-------------------------------

            editor.Restore(History.Redo());
            Console.WriteLine($"Name: {editor.Name}, Age: {editor.Age}");

            // We can add the the TextEditorStateManagementService as an attribute in TextEditor class 
            // To handle just one object (TextEditor) instead of handling 2 objects (TextEditor, TextEditorStateManagementService)
            // I think that will be the (Observer DP)
        }
    }
}
