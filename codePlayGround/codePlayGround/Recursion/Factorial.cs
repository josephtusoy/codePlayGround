using System;
using System.Collections.Generic;
using System.Text;

namespace codePlayGround.Recursion
{
    class Factorial
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(8));
            Console.ReadKey();
        }*/

        public static int factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * factorial(n - 1);
        }



    }
}
