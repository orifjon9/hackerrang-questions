using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Strings
{
    public class HackerRank : IElement
    {
        public void execute()
        {
            
            char[] words = new char[] { 'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k' };

            int nums = Convert.ToInt32(Console.ReadLine());
            int[] result = new int[nums];

            for (int i = 0; i < nums; i++)
            {
                string value = Console.ReadLine();
                int j = 0;
                int index = -1;
                while (j < words.Length && (index = value.IndexOf(words[j])) > -1)
                {
                    value = value.Substring(index +1);
                    j++;
                }

                if (j == words.Length)
                    result[i] = 1;
            }

            for (int i = 0; i < nums; i++)
            {
                Console.WriteLine((result[i] == 1 ? "YES" : "NO"));
            }
        }
    }
}
