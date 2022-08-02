using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Here We Check The Year Is Leap Year Or Not.
    /// </summary>
   public static class LeapYear
    {
        /// <summary>
        /// Check Leap Year.
        /// </summary>
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter Year is four digit Number");
            int Year = Convert.ToInt32(Console.ReadLine());

            if ((Year % 4 == 0) || (Year % 100 != 0) && (Year % 4 == 0))
            {

                Console.WriteLine("  Leap year  " + Year);
            }

            else
            {
                Console.WriteLine("  Not leap year  " + Year);
            }
        }
    }
}
