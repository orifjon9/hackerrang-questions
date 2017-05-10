using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class BonAppetit : IElement
    {
        public void execute()
        {
            int[] nk = Console.ReadLine().Split(' ').Select(v => Convert.ToInt32(v)).Take(2).ToArray();
            int n = nk[0];
            int k = nk[1];

            int[] c = Console.ReadLine().Split(' ').Select(v => Convert.ToInt32(v)).Take(n).ToArray();
            int b_c = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i == k) continue;
                sum += c[i];
            }

            int b_a = sum / 2;
            Console.WriteLine((b_a >= b_c) ? "Bon Appetit" : (b_c - b_a).ToString());
        }
    }
}
