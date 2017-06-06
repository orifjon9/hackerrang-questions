using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Sorting
{
    public class BigSorting : IElement
    {
        public void execute()
        {
            long nums = Convert.ToInt64(Console.ReadLine());
            List<String> list = new List<String>();

            //string[] arr = new string[nums];
            for (int i = 0; i < nums; i++)
            {
               // arr[i] = Console.ReadLine();
                list.Add(Console.ReadLine());
            }

            list.Sort(new BigNumberComparer());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
/*
            for (int i = 0; i < nums; i++)
            {
                for (int j = 0; j < (nums - 1 - i); j++)
                {
                    if (compareTo(arr[j], arr[j + 1]) == 1) {
                        swap(arr, j, j + 1);
                    }
                }
            }
            
            for (int r = 0; r < nums; r++)
            {
                Console.WriteLine(arr[r]);
            }
            */
        }

        public class BigNumberComparer : Comparer<string>
        {
            public override int Compare(string x, string y)
            {
                if (x.Length > y.Length)
                {
                    return 1;
                }
                else if (x.Length < y.Length)
                {
                    return -1;
                }
                else if (x.Length == y.Length)
                {

                    while (x.Length != 0)
                    {
                        long lv1 = Convert.ToInt64(x.Substring(0, (x.Length > 18 ? 18 : x.Length)));
                        long lv2 = Convert.ToInt64(y.Substring(0, (y.Length > 18 ? 18 : y.Length)));

                        x = x.Substring((x.Length > 18 ? 18 : x.Length));
                        y = y.Substring((y.Length > 18 ? 18 : y.Length));

                        if (lv1 > lv2)
                            return 1;
                        else if (lv1 < lv2)
                        {
                            return -1;
                        }
                    }
                }

                return 0;
            }
        }

        public int compareTo(string v1, string v2)
        {
            if (v1.Length > v2.Length)
            {
                return 1;
            }
            else if (v1.Length < v2.Length)
            {
                return -1;
            }
            else if (v1.Length == v2.Length)
            {

                while (v1.Length != 0)
                {
                    long lv1 = Convert.ToInt64(v1.Substring(0, (v1.Length > 18 ? 18 : v1.Length)));
                    long lv2 = Convert.ToInt64(v2.Substring(0, (v2.Length > 18 ? 18 : v2.Length)));

                    v1 = v1.Substring((v1.Length > 18 ? 18 : v1.Length));
                    v2 = v2.Substring((v2.Length > 18 ? 18 : v2.Length));

                    if (lv1 > lv2)
                        return 1;
                    else if (lv1 < lv2)
                    {
                        return -1;
                    }
                }
            }

            return 0;
        }

        public void swap(string[] arr,int left, int right) {
            string tmp = arr[left];
            arr[left] = arr[right];
            arr[right] = tmp;
        }
    }
}
