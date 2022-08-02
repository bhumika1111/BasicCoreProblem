using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    /// <summary>
    /// Here We Check Wheather An Alphabet Is Vowel Or Consonant.
    /// </summary>
 public static class CheckVowel
    {
        /// <summary>
        /// Checking An Alphabet.
        /// </summary>
        public static void CheckingAnAlphabet()
        {
            Console.WriteLine("Enter Any Character");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'
             ||ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
            {
                Console.WriteLine(ch + " is vowel");
            }
            else
            {
                Console.WriteLine("Enter Character Is Consonant." 
                    );
            }
        }
    }
}
