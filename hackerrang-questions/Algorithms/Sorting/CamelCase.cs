using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Algorithms.Sorting
{
    public class CamelCase : IElement
    {
        public void execute()
        {
            string input = Console.ReadLine();
            int count = char.IsLower(input[0]) ? 1 : 0;

            count += input.ToCharArray().Where(w => char.IsUpper(w)).Count();

            Console.WriteLine(count);
        }
    }
}
