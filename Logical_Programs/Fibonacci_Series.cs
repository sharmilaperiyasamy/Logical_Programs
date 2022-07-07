using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Fibonacci_Series
    {
        public void Series()
        {
            Console.WriteLine("Enter the number to find the fibonacci series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series is ");
            int a = 0, b = 1, c;
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; ++i)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
