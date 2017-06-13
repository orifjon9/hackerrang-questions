using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Implementation
{
    public class CountingValley : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            string ud = Console.ReadLine();

            int level = 0;
            int valley = 0;
            for (int i = 0; i < nums; i++)
            {
                if (ud[i] == 'U')
                {
                    if (level == -1)
                        valley++;
                    level++;
                }
                else
                {
                    level--;
                }
            }

            Console.WriteLine(valley);
        }
    }
}
