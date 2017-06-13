using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class CountingSort1 : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Take(nums).ToArray();
            int[] countarr = new int[100];

            for (int i = 0; i < nums; i++)
            {
                countarr[arr[i]] += 1;
            }
            
            Console.WriteLine(String.Join(" ", countarr));
        }
    }
}
