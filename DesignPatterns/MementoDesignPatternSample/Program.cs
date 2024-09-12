namespace MementoDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            TextHistory history = new TextHistory();

            editor.SetText("Hello");
            history.SaveState(editor.Save());

            editor.SetText("Hello , World!!!");
            history.SaveState(editor.Save());

            editor.SetText("Hello , World!!! How Are You?");

            Console.WriteLine("Current Text: " + editor.GetText());

            editor.Restore(history.Undo());
            Console.WriteLine("After 1 Undo: " + editor.GetText());

            editor.Restore(history.Undo());
            Console.WriteLine("After 2 Undo: " + editor.GetText());
        }
    }
}
