using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
     public static class LargestThreeNumber
    {
        public static void CheckingLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num2 > num3)
            {
                Console.WriteLine("Num1 Is Greater :");
            }
            else if(num2 > num1 && num2 > num3)
            { 
                Console.WriteLine("Num2 Is Greater :");
            }
            else if(num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Num3 Is Greater ");
            }

        }
    }
}
