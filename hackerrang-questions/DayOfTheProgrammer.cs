using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions
{
    class DayOfTheProgrammer : IElement
    {
        public void execute()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            int daysOfFebruary = 0;

            if (year < 1919)
            {
                daysOfFebruary = (year % 4 == 0) ? 29 : 28;

                if (year == 1918)
                    daysOfFebruary -= 13;
            }
            else {
                
                    daysOfFebruary = (year % 400 == 0 || ((year % 4 == 0) && (year % 100) != 0)) ? 29: 28;
            }

            int day = 256 - (215 + daysOfFebruary);
            Console.WriteLine("{0}.09.{1}", day, year);
            /*DateTime date = new DateTime(year, 1, 1);
            date = date.AddDays(255);
            
            if (year >= 1700 && year < 1917)
            {
                JulianCalendar calendar = new JulianCalendar();
                Console.WriteLine(calendar.ToDateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0).ToString("dd.MM.yyyy"));
            }
            else
            {
                Console.WriteLine(date.ToString("dd.MM.yyyy"));
            }*/

        }
    }
}
