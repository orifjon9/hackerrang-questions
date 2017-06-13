using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class DrawingBook : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0 && n == (p + 1) && p > 1){
                Console.WriteLine(1);
            }
            else
                Console.WriteLine(Math.Min((p / 2), (n-p) / 2));

            /*

            if ((n % 2 == 0 && n > p) || (n % 2 != 0 && (n - 1) > p)) {
                Console.WriteLine(1);
            }

            else
                Console.WriteLine(0);
                */
        }
    }
}
