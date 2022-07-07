using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Monthly_Payment
    {
        public static void cal_EMI()
        {
            Console.WriteLine("Enter the Principal : ");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the year : ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Interest : ");
            int R = Convert.ToInt32(Console.ReadLine());

            int n = 12 * Y;
            decimal r = (decimal)R / (12 * 100);
            double payment = (P * (double)(r)) / (1 - Math.Pow(1 + (double)(r), -n));
            Console.WriteLine("Monthly Payment is " + payment);
        }
    }
}
