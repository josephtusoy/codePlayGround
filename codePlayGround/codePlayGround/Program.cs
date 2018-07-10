using System;

namespace codePlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { -1, -2,0,9999};
            Console.WriteLine(solution(input));
            Console.Read();
  
        }


        public static int solution(int[] A)
        {
            Array.Sort(A);
            int result =1;
 
            foreach (int i in A)
                if (i == result) result++;
 
            return result;
        }


    }
}


 