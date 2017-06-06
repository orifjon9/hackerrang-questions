using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class AppleandOrange : IElement
    {
        public void execute()
        {
            int[] tokens_st = Console.ReadLine().Split(' ').Select(st=> Convert.ToInt32(st)).ToArray();

            int s = tokens_st[0];
            int t = tokens_st[1];

            int[] tokens_ab = Console.ReadLine().Split(' ').Select(ab => Convert.ToInt32(ab)).ToArray();
            int a = tokens_ab[0];
            int b = tokens_ab[1];

            int[] tokens_mn = Console.ReadLine().Split(' ').Select(mn => Convert.ToInt32(mn)).ToArray();
            int m = tokens_mn[0];
            int n = tokens_mn[1];
                        
            int[] apple = Console.ReadLine().Split(' ').Select(ap => Convert.ToInt32(ap)).Take(m).ToArray();
                        
            int[] orange = Console.ReadLine().Split(' ').Select(or => Convert.ToInt32(or)).Take(n).ToArray();

            int countApple = 0;
            int countOrange = 0;

            for (int i = 0; i < m; i++)
            {
                if (isPassDestination(s, t, a + apple[i])) {
                    countApple++;
                }
            }

            for (int j = 0; j < n;j++)
            {
                if (isPassDestination(s, t, b + orange[j]))
                {
                    countOrange++;
                }
            }

            Console.WriteLine(countApple);
            Console.WriteLine(countOrange);
        }

        public bool isPassDestination(int start, int end, int point) {
            return (start <= point && end >= point);
        }
    }
}
