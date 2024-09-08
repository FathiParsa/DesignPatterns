using System.ComponentModel.Design.Serialization;

namespace CompositeDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory root = new Directory("Root");
            root.Add(new File("File1.txt"));
            root.Add(new File("File2.txt"));

            Directory subDir = new Directory("SubDirectory");
            subDir.Add(new File("File3.txt"));
            subDir.Add(new File("File4.txt"));

            root.Add(subDir);

            root.Add(new File("File5.txt"));

            root.Display(1);

        }
    }
}
