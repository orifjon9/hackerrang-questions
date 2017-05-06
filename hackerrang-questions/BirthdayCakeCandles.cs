using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    public class BirthdayCakeCandles : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[] arrs = Console.ReadLine().Split(' ').Select(s => Convert.ToInt64(s)).Take(n).Where(w=> w> 0 && w<=(long)Math.Pow(10,7)).ToArray();

            long max = arrs.Max();

            Console.WriteLine(arrs.Where(w => w == max).Count());


        }
    }
}
