namespace AbstractFactoryDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarFactory toyotaFactory = new ToyotaFactory();
            ICarFactory fordFactory = new FordFactory();
            

            ISedan toyotaSedan = toyotaFactory.CreateSedan();
            ISUV toyotaSUV = toyotaFactory.CreateSUV();

            ISedan fordSedan = fordFactory.CreateSedan();
            ISUV fordSUV = fordFactory.CreateSUV();


            toyotaSedan.DisplayDetails();
            toyotaSUV.DisplayDetails();

            fordSedan.DisplayDetails();
            fordSUV.DisplayDetails();

        }
    }
}
