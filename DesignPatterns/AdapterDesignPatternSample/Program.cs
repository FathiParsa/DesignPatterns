namespace AdapterDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee(); 
            ITarget adapter = new Adapter(adaptee);

            Client client = new Client(adapter);
            client.Execute();
        }
    }
}
