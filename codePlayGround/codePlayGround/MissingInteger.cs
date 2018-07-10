using System;
using System.Collections.Generic;
using System.Text;

namespace codePlayGround
{
    class MissingInteger
    {
        /*
        int[] input = { -1, -2, 0, 9999 };
        Console.WriteLine(solution(input));
        Console.Read();
        */

        public static int SolveMissingInteger(int[] A)
        {
            Array.Sort(A);
            int result = 1;

            foreach (int i in A)
                if (i == result) result++;

            return result;
        }
    }
}
