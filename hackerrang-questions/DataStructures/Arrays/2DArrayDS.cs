using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.DataStructures.Arrays
{
    public class _2DArrayDS : IElement
    {
        public void execute()
        {
            int[,] darr = new int[6,6];

            int index = 0;
            while (index < 6)
            {
              int[] arr =  Console.ReadLine().Split(' ')
                     .Select(st => Convert.ToInt32(st))
                     .Take(6)
                     .ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    darr[index, i] = arr[i];
                }

                index++;
            }

            int max = -10000000;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int a = darr[i, j];
                    int b = darr[i, j + 1];
                    int c = darr[i, j + 2];

                    int d = darr[i + 1, j + 1];

                    int e = darr[i + 2, j];
                    int f = darr[i + 2, j + 1];
                    int g = darr[i + 2, j + 2];

                    int sum = a + b + c + d + e + f + g;
                    if (sum > max) {
                        max = sum;
                    }

                }
            }

            Console.WriteLine(max);
        }
    }
}
