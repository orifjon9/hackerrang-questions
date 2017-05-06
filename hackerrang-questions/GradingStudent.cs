using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class GradingStudent : IElement
    {
        public void execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];

            for (int i = 0; i < n; i++)
            {
                grades[i] = solved(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine(String.Join("\n", grades));

        }

        private int solved(int grade) {
            int newValue = grade;
            const int extraTwo = 2;
            const int extraOne = 1;

            if (newValue % 5 != 0 && (grade + extraTwo) >= 40)
            {
                int v = newValue / 5;
                switch (((v + 1) * 5) - newValue) {
                    case extraTwo:
                        newValue += extraTwo; break;
                    case extraOne:
                        newValue += extraOne; break;
                        
                }

                return newValue;
            }

            return grade;
        }
    }
}
