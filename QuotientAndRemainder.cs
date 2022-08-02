using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Here We Check Quotient And Remainder.
    /// </summary>
    public static class QuotientAndRemainder
    {
        /// <summary>
        /// Checking The Number.
        /// </summary>
        public static void CheckingQuotient()
        {
           
        

           Console.WriteLine("Enter A First Number:");
           int  dividend = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter A Second Number:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("dividend:{0} divisor: {1} ", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();




        }
    }
}
