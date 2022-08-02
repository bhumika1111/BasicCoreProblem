using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Here We Check  The Nth Harmonic Value.
    /// </summary>
   public static class HarmonicNumber
    {
        /// <summary>
        /// Check The Harmonic Series
        /// </summary>
        public static void CheckHarmonicSeries()
        {
            int N;
            float sum = 0, ans;

            Console.WriteLine(" Nth Harmonic Number Series: 1/1 + 1/2 + 1/3 +  1/4 ..........+ 1/N  ");

            Console.WriteLine("Enter the Number of terms N: ");
            N = Convert.ToInt32(Console.ReadLine());

            if (N != 0)
            {
                Console.WriteLine("We got Nth number of series: ");
            }

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(" 1/{0}  ", i);
                ans = (float)1 / i;
                sum = sum + ans;
            }
            Console.WriteLine("Sum of series of {0} terms : {1}\n ", N, sum);
            Console.ReadLine();
        }
   }
    
}
