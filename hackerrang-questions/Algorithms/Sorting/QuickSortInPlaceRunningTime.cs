using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class QuickSortInPlaceRunningTime : IElement
    {
        int countQuickShift = 0;
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Take(nums).ToArray();
            //int[] arr = new[] { 1, 3, 9, 8, 2, 7, 5 };
            int[] arr2 = new int[nums];
            Array.Copy(arr, arr2, nums);

            QuickSort(arr, 0, arr.Length - 1);
            

            Console.WriteLine(CalculateInsertionSortShiftCount(arr2) - countQuickShift);

        }

        public int CalculateInsertionSortShiftCount(int[] arr) {
            int countShift = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int tmp = arr[i];

                int j = i;

                while (j > 0 && tmp < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    arr[j - 1] = tmp;

                    countShift++;

                    j--;
                }
            }

            return countShift;
        }

        public void QuickSort(int[] arr, int lo, int hi) {
            if (lo < hi) {
                int possition = Partition(arr, lo, hi);
                ///print(arr);

                QuickSort(arr, lo, possition - 1);
                QuickSort(arr, possition + 1, hi);
            }
        }

        public int Partition(int[] arr, int lo, int hi) {
            int pivot = arr[hi];
            int i = lo - 1;
            for (int j = lo; j < hi; j++)
            {
                
                if (arr[j] < pivot)
                {
                    countQuickShift++;
                    i += 1;
                    if (i != j)
                    {
                        Swap(arr, i, j);
                    }
                }
            }

            countQuickShift++;
            Swap(arr, hi, i+1);

            return i + 1;
        }

        public void Swap(int[] arr, int i, int j) {
            //index++;
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
        
    }
}
