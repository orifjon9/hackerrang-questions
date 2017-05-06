using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class Kangaroo : IElement
    {
        public void execute()
        {
            int[] data = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Where(w=> w>=1 && w<=10000).Take(4).ToArray();
            long x1 = data[0];
            long v1 = data[1];
            long x2 = data[2];
            long v2 = data[3];

            string result = "NO";
            int count = 0;
            if ((x1 < x2 && v1 > v2) || (x1 > x2 && v1 < v2)) {
                while (count < 10000) {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2) {
                        result = "YES";
                        break;
                    }
                    count++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
