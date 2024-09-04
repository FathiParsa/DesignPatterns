namespace SingletonDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = Counter.Instance;
            counter1.Increment();
            counter1.Increment();
            Console.WriteLine("Counter1: " + counter1.GetCount());


            Counter counter2 = Counter.Instance;
            counter2.Increment();
            Console.WriteLine("Counter2: " + counter2.GetCount());


            Console.WriteLine(Object.ReferenceEquals(counter1, counter2));
        }
    }
}
