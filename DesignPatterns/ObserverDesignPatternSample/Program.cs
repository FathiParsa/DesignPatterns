namespace ObserverDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.SubjectState = "State 1";
            subject.SubjectState = "State 2";

            subject.Detach(observer1);

            subject.SubjectState = "State 3";
            Console.ReadLine();
        }
    }
}
