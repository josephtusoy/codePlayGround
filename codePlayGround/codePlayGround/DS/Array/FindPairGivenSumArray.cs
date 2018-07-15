using System;
using System.Collections.Generic;
using System.Text;

namespace codePlayGround.DS.Array
{
    class FindPairGivenSumArray
    {
        //int[] arr = { 8, 7, 2, 5, 3, 1 };
        // findPairSol1(arr, 10);
        // findPairSol2(arr, 10);

        static void findPairSol1(int[] arr, int sum)
        {
            bool hasResult = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        // Console.WriteLine("Print {0}  + {1} ", arr[i], arr[j]);
                        if (arr[i] + arr[j] == sum && j > i)
                        {
                            Console.WriteLine("Pair found at index {0} and {1} ({2} + {3}) ", i, j, arr[i], arr[j]);
                            hasResult = true;
                        }

                    }
                }
            }
            if (!hasResult)
                Console.WriteLine("Pair not found");
            Console.ReadLine();
        }


        static void findPairSol2(int[] arr, int sum)
        {
            bool hasResult = false;
           // Array.Sort(arr);
            int low = 0;
            int high = arr.Length - 1; 
            while (low < high)
            {
                if (arr[low] + arr[high] == sum)
                {
                    Console.WriteLine("Pair found at index {0} and {1} ({2} + {3}) ", low, high, arr[low], arr[high]);
                    Console.ReadLine();
                    return;

                }
                else
                {
                    if (arr[low] + arr[high] < sum)
                        low++;
                    else
                        high--;
                }
            }

        }



    }
}
