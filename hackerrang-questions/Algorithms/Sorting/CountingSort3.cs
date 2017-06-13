using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class CountingSort3 : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[nums];
            int[] countarr = new int[100];

            for (int i = 0; i < nums; i++)
            {
                string input = Console.ReadLine();
                arr[i] = Convert.ToInt32(input.Substring(0, input.IndexOf(" ")));
            }


            for (int i = 0; i < nums; i++)
            {
                countarr[arr[i]] += 1;
            }

            for (int i = 1; i < countarr.Length; i++)
            {
                countarr[i] += countarr[i - 1];
            }

            Console.WriteLine(String.Join(" ", countarr));
        }
    }
}
