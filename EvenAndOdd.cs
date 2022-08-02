using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Here We Check Wheather A Number IS Even Or Odd.
    /// </summary>
 public static class EvenAndOdd
    {
        /// <summary>
        /// Check The Number.
        /// </summary>
        public static void CheckingNumber()
        {
            int num;
            Console.WriteLine("Enter The Number:");
            num = Convert.ToInt32(Console.ReadLine());

            int c = num % 2;
            if (c==0)
            {
                Console.WriteLine("Enter Number Is Even");
            }
            else
            {
                Console.WriteLine("Enter Number Is Odd");
            }
        }
    }
}
