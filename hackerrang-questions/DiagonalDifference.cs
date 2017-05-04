using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    public class DiagonalDifference : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];

            for (int a_i = 0; a_i < n; a_i++)
            {
                a[a_i] = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Where(w => w >= -100 && w <= 100).Take(n).ToArray();
            }

            int primaryDiagonal = 0;
            int secondDiagonal = 0;

            for (int a_i = 0, a_j = n - 1; a_i < n; a_i++, a_j--)
            {
                primaryDiagonal += a[a_i][a_i];
                secondDiagonal += a[a_j][a_i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondDiagonal));
        }
    }
}
