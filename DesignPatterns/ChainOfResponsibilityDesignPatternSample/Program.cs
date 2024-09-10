namespace ChainOfResponsibilityDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplaintHandler lowLevelHandler = new LowLevelHandler();
            ComplaintHandler midLevelHandler = new MidLevelHandler();
            ComplaintHandler highLevelHandler = new HighLevelHandler();

            lowLevelHandler.SetNextHandler(midLevelHandler);
            midLevelHandler.SetNextHandler(highLevelHandler);

            lowLevelHandler.HandleComplaint("Complaint 1" , 1 );
            lowLevelHandler.HandleComplaint("Complaint 2", 2);
            lowLevelHandler.HandleComplaint("Complaint 3", 4);
        }
    }
}
