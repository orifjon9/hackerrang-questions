using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Strings
{
    public class CaesarCipher : IElement
    {
        public void execute()
        {
            int nums =  Convert.ToInt32(Console.ReadLine());
            string input =  Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            while (k > 26) {
                k -= 26;
            }


            string output = "";
            for (int i = 0; i < nums; i++)
            {
                char ch = input[i];
                int code = (int)ch;

                if (ch != '-') {
                    if (code >= 65 && code <= 90) {
                        code += k;
                        if (code > 90)
                            code -= 26;
                    }
                    else if (code >= 97 && code <= 122)
                    {
                        code += k;
                        if (code > 122)
                            code -= 26;
                    }
                }

                output += (ch == '-') ? ch : (char)code;
            }

            Console.WriteLine(output);
        }
    }
}
