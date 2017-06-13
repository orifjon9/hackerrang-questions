using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class MergeSort : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());

            int[] arr = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();

            int[] newarr = GetMergeSort(arr, 0, arr.Length - 1);
        }

        public int[] GetMergeSort(int[] arr, int left, int right) {
            return null;
        }

        public int[] GetMerge(int[] arr1, int[] arr2)
        {
            return null;
        }

    }
}
