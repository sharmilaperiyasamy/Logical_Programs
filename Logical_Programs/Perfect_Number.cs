using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Perfect_Number
    {
        public void Perfect()
        {
            Console.WriteLine("Enter the number to check it is a perfect number or not : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("The Divisors are " + i);
                    sum = sum + i;
                    if (sum != n)
                    {
                        Console.WriteLine("sum : " + sum);
                    }
                }
            }
            if (sum == n)
            {
                Console.WriteLine(n + " is a Perfect number");
            }
            else
            {
                Console.WriteLine(n + " is not a Perfect number");
            }
        }
    }
}
