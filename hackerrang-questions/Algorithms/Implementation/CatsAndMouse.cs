using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Implementation
{
    public class CatsAndMouse : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());

            string[] status = new string[nums];

            for (int i = 0; i < nums; i++)
            {
                int[] data = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Take(3).ToArray();

                int lengthForCatA = Math.Abs( data[2] - data[0]);
                int lengthForCatB = Math.Abs( data[2] - data[1]);

                if (lengthForCatA == lengthForCatB)
                {
                    status[i] = "Mouse C";
                }
                else if (lengthForCatA < lengthForCatB) {
                    status[i] = "Cat A";
                }
                else
                {
                    status[i] = "Cat B";
                }
            }

            foreach (var item in status)
            {
                Console.WriteLine(item);
            }

        }
    }
}
