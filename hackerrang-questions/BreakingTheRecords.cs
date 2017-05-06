using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class BreakingTheRecords : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[] scores = Console.ReadLine().Split(' ').Select(st => Convert.ToInt64(st)).Take(n).ToArray();

            long[] highestScore = new long[2];
            long[] lowestScore = new long[2];

            highestScore[0] = scores[0]; // initial value
            lowestScore[0] = scores[0]; // initial value

            for (int i = 1; i < n; i++)
            {
                if (highestScore[0] < scores[i]) {
                    highestScore[0] = scores[i];
                    highestScore[1] = highestScore[1] + 1;
                } else if (lowestScore[0] > scores[i])
                {
                    lowestScore[0] = scores[i];
                    lowestScore[1] = lowestScore[1] + 1;
                }
            }

            Console.WriteLine("{0} {1}", highestScore[1], lowestScore[1]);

        }
    }
}
