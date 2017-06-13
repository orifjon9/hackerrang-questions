using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Sorting
{
    public class SuperReducedString : IElement
    {
        public void execute()
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                int lastIndex = output.Length - 1;
                if (lastIndex > -1 && output[lastIndex] == ch)
                {
                    output = output.Remove(lastIndex,1);
                }
                else
                {
                    output += ch;
                }
            }

            Console.WriteLine((output.Length > 0 ? output: "Empty String"));
        }
    }
}
