using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse
    {
        public void Reverse_number()
        {
            Console.WriteLine("Enter the number to find the reverse of a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;
            int rem, rev = 0;

            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("The reverse of " + num + " is " + rev);
        }
    }
}
