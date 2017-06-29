using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Strings
{
    public class Pangrams : IElement
    {
        public void execute()
        {
            string input = Console.ReadLine().ToLower();

            //Console.WriteLine((int)'a' + " " + (int)'z');
            //97 122

            int index = 97;
            while (index <= 122) {
                if (input.IndexOf((char)index) == -1)
                    break;

                index++;
            }

            Console.WriteLine((index > 122 ? "" : "not ") + "pangram");
        }
    }
}
