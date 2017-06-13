using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class Intro : IElement
    {
        public void execute()
        {
            int el = Convert.ToInt32(Console.ReadLine());
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();

            for (int i = 0; i < nums; i++)
            {
                if (arr[i] == el) {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
