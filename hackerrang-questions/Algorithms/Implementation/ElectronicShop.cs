using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrang_questions.Implementation
{
    public class ElectronicShop : IElement
    {
        public void execute()
        {
            long[] data = Console.ReadLine().Split(' ').Select(st => Convert.ToInt64(st)).Take(3).ToArray();
            long money = data[0];
            long keyboardsCount = data[1];
            long USBsCount = data[2];

            List<long> listDiffKeyboards = Console.ReadLine().Split(' ')
                .Select(st => Convert.ToInt64(st))
                .Where(w => w < money)
                .Take((int)keyboardsCount)
                .Select(s=> money - s)
                .ToList();

            List<long> listUSBs = Console.ReadLine().Split(' ')
                .Select(st => Convert.ToInt64(st))
                .Where(w => w <= money)
                .Take((int)USBsCount)
                .Select(s =>s)
                .ToList();

            long total = -1;

            foreach (long different in listDiffKeyboards.OrderByDescending(o=>o))
            {
                long filteredUSBs = listUSBs.Where(w => w <= different)
                    .OrderByDescending(o => o)
                    .FirstOrDefault();

                if (filteredUSBs > 0)
                {
                    long sum = (money - different) + filteredUSBs;

                    if (total < sum) {
                        total = sum;
                    }
                }
            }

            Console.WriteLine(total);

        }
    }
}
