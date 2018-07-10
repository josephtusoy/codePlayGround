using System;
using System.Collections.Generic;
using System.Text;

namespace codePlayGround
{
    class StringToIntNonParse
    {


        public static int converToString(String N)
        {
            int result = 0;
            char[] digits = N.ToCharArray();
            int zeroAscii = (int)'0';
            foreach (char c in digits)
            {
                result = (result * 10) + ((int)c - zeroAscii);
            }
            return result;
        }
    }
}
