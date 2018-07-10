using System;
using System.Collections.Generic;
using System.Text;

namespace codePlayGround.DS.Array
{
    //https://www.geeksforgeeks.org/rearrange-array-arri/

    class RearrangeArray
    {


        /*
             int[] input1 = { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };
                int[] input2 = {19, 7, 0, 3, 18, 15, 12, 6, 1, 8, 11, 10, 9, 5, 13, 16, 2, 14, 17, 4};
                print(ArrRearrange(input1));
                print(ArrRearrange(input2));
                Console.Read();
         */


        public static void print(int[] input)
        {
            Console.WriteLine(String.Join(",", input));
        }
        public static int[] ArrRearrange(int[] input)
        {
            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (DoExist(i, input))
                    result[i] = i;
                else
                    result[i] = -1;
            }
            return result;
        }

        public static bool DoExist(int find, int[] input)
        {
            bool result = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == find)
                    return true;
            }
            return result;
        }
    }

}
