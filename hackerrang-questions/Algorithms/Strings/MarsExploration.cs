using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Strings
{
    public class MarsExploration : IElement
    {
        public void execute()
        {
            string input = Console.ReadLine();

            int incorrectLetters = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != "SOS"[i % 3])
                    incorrectLetters++;
            }

            Console.WriteLine(incorrectLetters);
        }
    }
}
