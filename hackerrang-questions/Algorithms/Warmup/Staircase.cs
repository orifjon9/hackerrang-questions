using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    public class Staircase : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string stair = string.Empty;
                for (int j = 1; j <= n; j++)
                {
                    stair += (j > (n-i)) ? "#" : " ";
                }

                Console.WriteLine(stair);
            }
        }
    }
}
