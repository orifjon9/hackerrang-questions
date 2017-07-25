using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Strings
{
    public class PalindromeIndex : IElement
    {
        public void execute()
        {
            int count = 3;// Convert.ToInt32(Console.ReadLine());
            string[] words = new string[count];
            /*
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }*/

            words = new string[] { "aaab","baa","aaa"};

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (!IsPalindrom(word))
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (IsPalindrom(word.Remove(j, 1))) {
                            Console.WriteLine(j);
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
        }

        public bool IsPalindrom(string value) {
            //return value == value.Reverse<char>().ToString();
            for (int i = 0, j = (value.Length - 1); i < value.Length / 2; i++, j--)
            {
                if (value[i] != value[j])
                    return false;
            }

            return true;
        }
    }
}
