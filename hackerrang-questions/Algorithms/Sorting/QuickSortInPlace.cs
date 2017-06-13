using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class QuickSortInPlace : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Take(nums).ToArray();
            

            QuickSort(arr, 0, arr.Length - 1);

        }

        public void QuickSort(int[] arr, int lo, int hi) {
            if (lo < hi) {
                int possition = Partition(arr, lo, hi);
                print(arr);

                QuickSort(arr, lo, possition - 1);
                QuickSort(arr, possition + 1, hi);
            }
        }

        public int Partition(int[] arr, int lo, int hi) {
            int pivot = arr[hi];
            int i = lo - 1;
            for (int j = lo; j < hi; j++)
            {
                if (arr[j] < pivot) {
                    i += 1;
                    if (i != j) {
                        
                        Swap(arr,i, j);
                    }
                }
            }
            Swap(arr, hi, i+1);

            return i + 1;
        }

        public void Swap(int[] arr, int i, int j) {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        public void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


    }
}
