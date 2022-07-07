using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Square_Root
    {
        public static void sqrt()
        {
            Console.WriteLine("Enter the number : ");
            double n = Convert.ToInt32(Console.ReadLine());
            double epsilon = 1e-15;
            double t = n;

            while (Math.Abs(t - n / t) > epsilon * t)
            {
                t = (n / t + t) / 2;
            }
            Console.WriteLine("Square Root of " + n + " : " + t);
        }
    }
}
