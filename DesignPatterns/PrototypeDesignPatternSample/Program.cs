namespace PrototypeDesignPatternSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car originalCar = new Car("Tesla", "Model S", 1000);
            Car clonedCar = (Car)originalCar.Clone();

            Console.WriteLine("Original Car : "+ originalCar);
            Console.WriteLine("Cloned car: " + clonedCar + "\ns");

            clonedCar.Model = "Roadster";

            Console.WriteLine("After Modifying Cloned Cars Model:\n");

            Console.WriteLine("Original Car : " + originalCar);
            Console.WriteLine("Cloned Car : " + clonedCar);
        }
    }
}
