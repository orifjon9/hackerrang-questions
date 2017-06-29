using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace hackerrang_questions.Algorithms.Dynamic_Programming
{
    public class FibonacciModified : IElement
    {
        public void execute()
        {
            UInt64[] inputs = Console.ReadLine().Split(' ').Select(s => Convert.ToUInt64(s)).ToArray();

            BigInteger[] fibonacciArray = new BigInteger[inputs[2]];
            fibonacciArray[0] = inputs[0];
            fibonacciArray[1] = inputs[1];


            for (int i = 2; i < fibonacciArray.Length; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 2] + (fibonacciArray[i - 1] * fibonacciArray[i - 1]);
            }

            Console.WriteLine(fibonacciArray[fibonacciArray.Length - 1]);
        }
    }
}
