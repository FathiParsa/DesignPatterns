namespace BuilderDesignPatternSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            IComputerBuilder gamingBuilder = new GamingComputerBuilder();
            ComputerDirector director  = new ComputerDirector(gamingBuilder);
            director.BuildComputer();
            Computer gamingComputer = director.GetComputer();
            Console.WriteLine("Gaming Computer : " + gamingComputer);

            IComputerBuilder officeBuilder = new OfficeComputerBuilder();
            director = new ComputerDirector(officeBuilder);
            director.BuildComputer();
            Computer officeComputer = director.GetComputer();
            Console.WriteLine("Office Computer : " + officeComputer);
        }
    }
}
