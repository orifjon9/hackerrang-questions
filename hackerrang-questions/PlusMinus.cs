using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{

    public class PlusMinus : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrs = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Take(n).ToArray();

            decimal positiveCount = 0;
            decimal negativeCount = 0;
            decimal zeroCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (arrs[i] == 0)
                {
                    zeroCount++;
                }
                else if (arrs[i] > 0)
                {
                    positiveCount++;
                }
                else {
                    negativeCount++;
                }
            }

            Console.WriteLine("{0:0.000000}",(positiveCount / (decimal)n));
            Console.WriteLine("{0:0.000000}", (negativeCount / (decimal)n));
            Console.WriteLine("{0:0.000000}", (zeroCount / (decimal)n));

        }
    }
}
