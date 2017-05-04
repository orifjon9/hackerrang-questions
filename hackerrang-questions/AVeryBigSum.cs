using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    public class AVeryBigSum : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            long maxValue = (long)Math.Pow(10, 10);
            /*long[] values = Console.ReadLine().Split(' ').Take(n).Select(v => Convert.ToInt64(v))
                .Where(w => (w >= 0 && w <= maxValue)).ToArray();
                */
            Console.WriteLine(Console.ReadLine().Split(' ').Take(n).Select(v => Convert.ToInt64(v))
                .Where(w => (w >= 0 && w <= maxValue)).Sum());
            /*
            bool isEmpty = false;
            long value = 0;
            string result = String.Empty;

            while (!isEmpty)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    long item = values[i];
                    
                    isEmpty = ((i == 0) ? (item == 0) : (isEmpty && (item == 0)));

                    if (item == 0) continue;

                    values[i] /= 10;
                    value += (item > 9) ? (item % 10) : item;

                }
                if (isEmpty) break;

                result = (value > 0 ? (value % 10) : 0) + result;
                value = value / 10;

            }
            Console.WriteLine(result);*/

        }
    }
}
