using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.DataStructures.Arrays
{
    public class ArraysDS : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ')
                    .Select(st => Convert.ToInt32(st))
                    .Take(nums)
                    .ToArray();

            for (int i = arr.Length - 1; i >=0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            /*int nums = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Console.ReadLine().Split(' ')
            .Select(st => Convert.ToInt32(st))
            .Take(nums).ToList().ForEach(ac => stack.Push(ac));

            while (stack.Count > 0) {
                Console.Write(stack.Pop() + " ");
            }*/
        }
    }
}
