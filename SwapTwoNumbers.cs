using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    ///  Here We Check Swapping Of Two Numbers Without Using Third Variable
    /// </summary>
    public static  class SwapTwoNumbers
    {
        public static void CheckSwapNumber()
        {
            int a = 50, b = 100;
            Console.WriteLine("Before Swapping a = "  +  a + " b = "  + b);
            a = a * b; a = 5000;
            b = a / b; b = 50;
            a = a / b;
            Console.WriteLine(" After Swapping a = "  + a + " b = "  + b);

        }
    }
}
