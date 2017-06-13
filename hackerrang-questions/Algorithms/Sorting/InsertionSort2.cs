using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class InsertionSort2 : IElement
    {
        public void execute()
        {
            int nums = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();

            for (int i = 1; i < nums; i++)
            {
                int tmp = arr[i];

                int j = i;

                while (j > 0 && tmp < arr[j - 1]) {
                    arr[j] = arr[j - 1];
                                        
                    arr[j - 1] = tmp;
                    tmp = arr[j - 1];
                    j--;
                }
                print(arr);
            }

            

        }

        public void print(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
