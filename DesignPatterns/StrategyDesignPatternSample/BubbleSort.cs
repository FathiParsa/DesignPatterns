using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternSample
{
    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting Using Bubble Sort.");

            for (int i = 0; i < list.Count -1; i++)
            {
                for (int j = 0; j < list.Count -i -1; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        int temp = list[j];
                        list[j] = list[j+1];
                        list[j+1] = temp;
                    }
                }

            }
        }
    }
}
