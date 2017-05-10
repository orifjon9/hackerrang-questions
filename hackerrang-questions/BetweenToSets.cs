using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class BetweenToSets : IElement
    {
        public void execute()
        {
            int[] ab = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).ToArray();

            int[] a = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Where(w => w >= 1 && w <= 100).Take(ab[0]).ToArray();
            int[] b = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Where(w => w >= 1 && w <= 100).Take(ab[1]).ToArray();

            int minA = a.Min();
            int minB = b.Min();

            int[] xFactor = new int[minB + 1];

            for (int i = minB; i > 0; i--)
            {
                bool isFactorForAll = true;
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] % i != 0) {
                        isFactorForAll = false;
                        break;
                    }
                }

                if (isFactorForAll) {
                    xFactor[i] = 1;
                }
            }

            int count = 0;
            for (int i = minA; i < xFactor.Length; i++)
            {
                if (xFactor[i] == 0) continue;

                bool isDevideForAll = true;
                for (int j = 0; j < a.Length; j++)
                {
                    if (i% a[j] != 0)
                    {
                        isDevideForAll = false;
                        break;
                    }
                }

                if (isDevideForAll)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
