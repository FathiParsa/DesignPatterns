using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternSample
{
    public class InsertionSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting Using insertion sort.");
            for (int i = 1; i < list.Count; i++)
            {
                int key = list[i];
                int j = i - 1;
                while (j >= 0 && list[j] > key)
                {
                    list[j = 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
        }
    }
}
