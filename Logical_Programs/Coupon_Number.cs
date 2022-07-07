using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Coupon_Number
    {
        public void Coupon()
        {
            Console.WriteLine("Enter the N distinct coupon number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int flag, count = 1;
            Random random = new Random();
            int rand_value = random.Next(1, n + 1);
            int[] coupon_num = new int[n];
            coupon_num[0] = rand_value;

            for (int i = 1; i <= n; i++)
            {
                flag = 0;
                i--;
                rand_value = random.Next(1, n + 1);
                count++;

                for (int j = 0; j < i; j++)
                {
                    if (rand_value == coupon_num[j])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    coupon_num[i] = rand_value;
                    Console.WriteLine("Distinct coupon is : " + rand_value);
                    i++;
                }
            }
            Console.WriteLine("Total random number needed to generate distinct coupon is : " + count);
        }
    }
}
