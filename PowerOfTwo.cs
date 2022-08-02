using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Here We Check The Table Of Power Of Two.
    /// </summary>
    public static class PowerOfTwo
    {
        /// <summary>
        /// Check Power Of Two.
        /// </summary>
        public static void CheckingPowerOfTwo()
        {

            Console.WriteLine("Input any value:");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 0 && N < 31)
            {
                Console.WriteLine("Entered the value within the range:  " + N);

                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }

            }
            else
            {
                Console.WriteLine("Entered value is not in range ");
            }
        }
    }
}
