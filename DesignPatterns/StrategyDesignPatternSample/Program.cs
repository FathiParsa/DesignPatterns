namespace StrategyDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 9, 8, 4, 6, 5, 7};
            SortContext context = new SortContext();

            context.SetSortStrategy(new BubbleSort());
            context.Sort(numbers);

            context.SetSortStrategy(new QuickSort());
            context.Sort(numbers);

            context.SetSortStrategy(new InsertionSort());
            context.Sort(numbers);
        }
    }
}
