namespace IteratorDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordCollection words = new WordCollection();
            words.AddWord("Hello");
            words.AddWord("World");
            words.AddWord("Iterator");
            words.AddWord("Pattern");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
