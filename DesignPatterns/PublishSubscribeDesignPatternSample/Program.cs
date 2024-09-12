namespace PublishSubscribeDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber subscriber1 = new Subscriber("Subscriber 1");
            Subscriber subscriber2 = new Subscriber("Subscriber 2");

            publisher.DataPublished += subscriber1.OnDataReceived;
            publisher.DataPublished += subscriber2.OnDataReceived;

            publisher.Publish("First Message");
            publisher.Publish("Second Message");

            publisher.DataPublished -= subscriber1.OnDataReceived;
            publisher.Publish("Third Message");
        }
    }
}
