using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Prime_Number
    {
        public void Prime()
        {
            Console.WriteLine("Enter the number to check it a Prime number or not : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(n + " is a Prime number");
            }
            else
            {
                Console.WriteLine(n + " is not a Prime number");
            }
        }
    }
}
