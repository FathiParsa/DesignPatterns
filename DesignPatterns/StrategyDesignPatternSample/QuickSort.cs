using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternSample
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting Using Quick Sort");
            QuickSortHelper(list , 0 , list.Count -1);
        }

        private void QuickSortHelper(List<int> list , int left , int right)
        {
            if (left < right)
            {
                int pivot = Partition(list , left , right);
                QuickSortHelper(list , left , pivot -1);
                QuickSortHelper(list , pivot + 1 , right);
            }
        }

        private int Partition(List<int> list , int left , int right)
        {
            int pivot = list[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (list[j] <= pivot)
                {
                    i++;
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            int temp2 = list[i + 1];
            list[i + 1] = list[right];
            list[right] = temp2;

            return i + 1;
        }
    }
}
