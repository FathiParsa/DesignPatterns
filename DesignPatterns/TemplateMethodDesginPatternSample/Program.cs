namespace TemplateMethodDesginPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execute Alghorithm ConcreteClassA :");
            AbstractClass classA = new ConcreteClassA();
            classA.TemplateMethod();

            Console.WriteLine("Execute Algorithm ConcreteClassB :");
            AbstractClass classB = new ConcreteClassB();
            classB.TemplateMethod();
        }
    }
}
