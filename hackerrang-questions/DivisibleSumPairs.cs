using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class DivisibleSumPairs : IElement
    {
        public void execute()
        {
            int[] nk = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Take(2).ToArray();
            int n = nk[0];
            int k = nk[1];

            int[] aList = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Take(n).ToArray();

            int counter = 0;
            for (int i = 0; i < aList.Length - 1; i++)
            {
                for (int j = i+1; j < aList.Length; j++)
                {
                    if ((aList[i] + aList[j])%k ==0) counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
