using System;
using System.Collections.Generic;
using System.Text;
//https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
namespace codePlayGround.DS.Array
{

    /*
      static void Main(string[] args)
        {
            int[] s1 = { 5, 1, 1, 6, 2, 2, 4, 4, 5 };
            Console.Write(SolveMissingInteger(s1));
            Console.ReadKey();
            Console.ReadKey();
        }
     */

    class OddOccurencesInArray
    {


        public static int OddOccurences(int[] A)
        {
            if (A.Length <= 0)
                return 0;

            if (A.Length == 1)
                return A[1];

            //Array.Sort(A);

            int current = 0;
            int satisfy = 0;
            for (int i = 0; i < A.Length; i++)
            {

                current = A[i];
                if (satisfy == 1)
                {
                    if (current == A[i - 1])
                        satisfy = -1;
                    else
                        break;
                }

                satisfy++;
            }
            return current;
            // 1 1 
            // 1 2
        }

    }
}
