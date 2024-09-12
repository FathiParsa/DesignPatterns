namespace StateDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OffState());

            context.Request();

            context.Request();
        }
    }
}
