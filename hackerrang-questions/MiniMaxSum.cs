using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    public class MiniMaxSum : IElement
    {
        public void execute()
        {
            long maxValue = (long)Math.Pow(10, 10);

            long[] arrs = Console.ReadLine().Split(' ').Select(s => Convert.ToInt64(s)).Take(5)
                .Where(w=> (w >= 0 && w <= maxValue)).ToArray();

            long min = arrs.Sum();
            long max = arrs[0];

            for (int i = 0; i < arrs.Length; i++)
            {
                long total = 0;
                for (int j = 0; j < arrs.Length; j++)
                {
                    if (i == j) continue;

                    total += arrs[j];
                }

                if (min > total) {
                    min = total;
                }
                if (max < total) {
                    max = total;
                }
            }

            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
