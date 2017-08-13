using hackerrang_questions.Algorithms.Dynamic_Programming;
using hackerrang_questions.Algorithms.Implementation;
using hackerrang_questions.Algorithms.Sorting;
using hackerrang_questions.Algorithms.Strings;
using hackerrang_questions.DataStructures.Arrays;
using hackerrang_questions.Implementation;
using hackerrang_questions.Sorting;
using hackerrang_questions.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class Program
    {
        /* static void Main(string[] args)
         {
             try
             {
                 int n = Convert.ToInt32(Console.ReadLine());
                 string[] arr_temp = Console.ReadLine().Split(' ');
                 int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                 if (arr.Length != n) {
                     throw new Exception("not full input");
                 }

                 int sum = 0;

                 for (int i = 0; i < n; i++)
                 {
                     sum += arr[i];
                 }
                 Console.WriteLine(sum);
             }
             catch (Exception) {
                 Console.WriteLine("~ no response on stdout ~");
             }
         }*/

        static void Main(String[] args)
        {
            Console.WriteLine(maxDifferece(new int[] { 2, 3, 10, 2, 4, 8, 1 }));
            Console.WriteLine(maxDifferece(new int[] { 7,9,5,6,3,2 }));


            //Console.WriteLine(isMutation2("hello", "hey"));
            //Console.WriteLine(isMutation2("hello", "oleh"));

            IElement element = new PalindromeIndex();
            element.execute();
            Console.ReadLine();

            /*
            int[] a = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Where(w => w >= 1 && w <= 100).ToArray();
            int[] b = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).Where(w => w >= 1 && w <= 100).ToArray();

            if (a.Length != 3 || b.Length != 3) {
                Console.WriteLine("~ no response on stdout ~");
            }
            int[] result = new int[] { 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                    result[0] += 1;
                else if (a[i] < b[i])
                    result[1] += 1;
            }
            Console.WriteLine(String.Join(" ", result));
            */
        }

        public static int maxDifferece(int[] arr)
        {
            int min, diff = -1;
            if (arr.Length == 0)
                return diff;

            min = arr[0];
            for (int i = 1; i < arr.Length; i++) //O(N)
            {
                diff = Math.Max(diff, arr[i] - min);
                min = Math.Min(min, arr[i]);
            }
            return diff;

            /*int maxValue = -1;
            for (int i = 0; i < arr.Length; i++) //O(N^2)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (i < j && arr[j] - arr[i] > maxValue)
                    {
                        maxValue = arr[j] - arr[i];
                    }
                }
            }

            return maxValue;*/
        }

        public static bool isMutation(string str1, string str2)
        {

            char[] strChars1 = str1.ToLower().ToCharArray()
                .GroupBy(ch => ch)
                .Select(s => s.Key)
                .OrderBy(o => o)
                .ToArray();
            char[] strChars2 = str2.ToLower().ToCharArray()
                .GroupBy(ch => ch)
                .Select(s => s.Key)
                .OrderBy(o => o)
                .ToArray();

            if (strChars1.Length == strChars2.Length)
            {
                for (int i = 0; i < strChars1.Length; i++)
                {
                    if (strChars1[i] != strChars2[i])
                        return false;
                }

                return true;
            }

            return false;
        }

        public static bool isMutation2(string source, string target)
        {
            int[] index = new int[255];
            for (int i = 0; i < target.Length; i++)
            {
                char ch = target[i];
                index[(int)ch] += 1;
            }

            for (int i = 0; i < source.Length; i++)
            {
                char ch = source[i];
                if (index[(int)ch] == 0)
                    return false;
            }

            return true;
        }
    }
}
