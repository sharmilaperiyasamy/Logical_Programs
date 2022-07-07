using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Day_Of_Week
    {
        public static void dayOfWeek()
        {
            Console.WriteLine("Enter the Day of the date : ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Month of the date : ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Year of the date : ");
            int y = Convert.ToInt32(Console.ReadLine());

            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            if (d >= 1 && d <= 31 && m >= 1 && m <= 12 && y >= 1000 && y <= 10000)
            {
                int y1 = y - (14 - m) / 12;
                int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
                int m1 = m + 12 * ((14 - m) / 12) - 2;
                int d1 = (d + x + 31 * m1 / 12) % 7;
                Console.WriteLine("The Day on " + d + "-" + m + "-" + y + " is " + days[d1]);
            }
            else
            {
                Console.WriteLine("Please enter the valid date");
                dayOfWeek();
            }
        }
    }
}
