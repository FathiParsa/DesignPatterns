namespace FactoryMethodDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory dogFactory = new DogFactory();
            IAnimal dog = dogFactory.CreateAnimal();
            dog.Speak();

            AnimalFactory catFactory = new CatFactory();
            IAnimal cat = catFactory.CreateAnimal();
            cat.Speak();
        }
    }
}
