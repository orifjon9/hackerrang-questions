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
            IElement element = new SockMerchant();
            element.execute();
            
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
    }
}
