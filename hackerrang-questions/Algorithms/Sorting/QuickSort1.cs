using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class QuickSort1 : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Take(nums).ToArray();

            arr = QuickSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public int[] QuickSort(int[] arr)
        {
            if (arr.Length < 2)
                return arr;

            int pivot = arr[0];
            Tuple<int[], int[], int[]> tuple =  Partition(arr, pivot);

            int[] leftArray = QuickSort(tuple.Item1);
            int[] rightArray = QuickSort(tuple.Item3);

            return JoinArrays(leftArray, tuple.Item2, rightArray);
        }

        public Tuple<int[], int[], int[]> Partition(int[] arr, int pivot) {
            List<int> left = new List<int>();
            List<int> equal = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i];

                if (value < pivot)
                {
                    left.Add(value);
                }
                else if (value > pivot)
                {
                    right.Add(value);
                }
                else
                {
                    equal.Add(value);
                }
            }

            return new Tuple<int[], int[], int[]>(left.ToArray(), equal.ToArray(), right.ToArray());
        }

        public int[] JoinArrays(int[] arr1, int[] arr2, int[] arr3) {
            int[] arr = new int[arr1.Length + arr2.Length + arr3.Length];

            Array.Copy(arr1, arr, arr1.Length);
            Array.Copy(arr2, 0, arr, arr1.Length, arr2.Length);
            Array.Copy(arr3, 0, arr, arr1.Length + arr2.Length, arr3.Length);

            return arr;
        }

    }
}
