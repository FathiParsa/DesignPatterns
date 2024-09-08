namespace DecoratorDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffee myCoffee = new SimpleCoffee();
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");

            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");

            myCoffee = new SugarDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");

            myCoffee = new WhipDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");
        }
    }
}
