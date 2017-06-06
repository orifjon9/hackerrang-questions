using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Strings
{
    public class TwoCharacters : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            string word = Console.ReadLine().ToLower();
            string newwords = String.Empty;
            int max = 0;
            
            //int[] arr = new int[256];
            
            for (int i = 0; i < nums; i++)
            {
                //int index = (int)word[i];
                //arr[index] += 1;

                if (!newwords.Contains(word[i])) {
                    newwords += word[i];
                }
            }

            for (int i = 0; i < newwords.Length; i++)
            {
                for (int j = i+1; j < newwords.Length; j++)
                {
                    char x = newwords[i];
                    char y = newwords[j];
                    string subString = string.Empty;
                    bool isNice = true;

                    for (int k = 0; k < word.Length; k++)
                    {
                        char subChar = word[k];
                        if (subChar == x || subChar == y)
                        {
                            subString += subChar;
                            int subStringCount = subString.Length;

                            if (subStringCount > 1 && subString[subStringCount - 1] == subString[subStringCount - 2])
                            {
                                isNice = false;
                                break;
                            }
                        }
                    }

                    if (isNice && subString.Length > 0) {
                        max = Math.Max(max, subString.Length);
                    }

                }
            }

            Console.WriteLine(max);
            
        }
    }
}
