using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class MigratoryBirds : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] birds = Console.ReadLine().Split(' ').Select(st => Convert.ToInt32(st)).Take(n).ToArray();

            int[] types = new int[5];
            for (int i = 0; i < types.Length; i++)
            {
                types[i] = birds.Where(w => w == (i + 1)).Count();
            }

            int max = 0;
            for (int j = 1; j < types.Length; j++)
            {
                if (types[max] < types[j])
                    max = j;
            }

            Console.WriteLine(max + 1);
        }
    }
}
