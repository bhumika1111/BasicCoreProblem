using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
  public static class Factors
    {
        public static void CheckingPrimeFactorization()
        {
            int i, num, b;
            
            Console.WriteLine("Please Enter Any Number To Find Factors:");
            num = Convert.ToInt32(Console.ReadLine());
           
            for (i = 2; i*i <= num; i++)
            {
                if(num % i == 0)
                {
                    b = 0;
                    while (num % i == 0)
                    {
                        num /= i;
                        b++;
                    }
                    Console.WriteLine($"{i} is a Prime Factor {b} Times!");
                }

            }
              
            
        }
  }
}

