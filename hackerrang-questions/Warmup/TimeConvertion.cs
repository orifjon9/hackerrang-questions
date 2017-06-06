using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    public class TimeConvertion : IElement
    {
        public void execute()
        {
            DateTime time24Hour = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(time24Hour.ToString("HH:mm:ss"));
        }
    }
}
