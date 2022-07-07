using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Nibble
    {
        public static void swap_nibble()
        {
            Console.WriteLine("Enter the Decimal number : ");
            int dec = Convert.ToInt32(Console.ReadLine());

            string bin = Convert.ToString(dec, 2);

            if (bin.Length % 2 != 0)
            {
                bin = "0" + bin;
            }

            string nibble1 = bin.Substring(0, 4);
            string nibble2 = bin.Substring(4);
            Console.WriteLine("Binary number before Swapping : " + bin);

            string temp = nibble1;
            nibble1 = nibble2;
            nibble2 = temp;
            bin = nibble1 + nibble2;
            int nibble_swap = Convert.ToInt32(bin, 2);
            Console.WriteLine("Binary number after swapping : " + bin);
            Console.WriteLine("Decimal number of swapped binary number : " + nibble_swap);
        }
    }
}
