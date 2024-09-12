namespace FlyWeightDesignPatternSample
{
    public class Program
    {
        private static string[] colors = { "Red", "Green", "Black", "Blue", "White" };

        private static string GetRandomColor()
        {
            Random random = new Random();
            return colors[random.Next(colors.Length)];
        }

        private static int GetRandomX()
        {
            Random random = new Random();
            return random.Next(100);
        }

        private static int GetRandomY()
        {
            Random random = new Random();
            return random.Next(100);
        }
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Circle circle = CircleFactory.GetCircle(GetRandomColor());
                circle.SetX(GetRandomX());
                circle.SetY(GetRandomY());
                circle.SetRadius(100);
                circle.Draw();
                Task.Delay(100).Wait();
            }
        }
    }
}
