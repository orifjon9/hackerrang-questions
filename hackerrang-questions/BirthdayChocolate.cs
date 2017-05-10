using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class BirthdayChocolate : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] s = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Take(n).ToArray();

            int[] dm = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Take(2).ToArray();

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((dm[1] + i) > s.Length) break;

                int sum = 0;
                for (int j = 0; j < dm[1]; j++)
                {
                    sum += s[i + j];
                }

                if (sum > 0 && sum == dm[0]) {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
