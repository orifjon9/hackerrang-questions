using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class SockMerchant : IElement
    {
        public void execute()
        {
            int n =  Convert.ToInt32(Console.ReadLine());
            List<int> socks = new List<int>();

            Console.ReadLine().Split(' ').Select(v => Convert.ToInt32(v)).Take(n)
                .ToList().ForEach(v =>
                {
                    if (socks.Contains(v))
                    {
                        socks.Remove(v);
                    }
                    else
                    {
                        socks.Add(v);
                    }
                });

            Console.WriteLine(socks.Count == n ? 0 : (n - socks.Count) / 2);

        }
    }
}
