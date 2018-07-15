using System;
using System.Collections.Generic;
using System.Text;

namespace codePlayGround.StringF
{

    class countYZ
    {

        public static int countYZ_Sol1(string str)
        {
            str = str.ToLower();
            if (str.Length == 0)
                return 0;

            StringBuilder sb = new StringBuilder();
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                Char letter = Char.Parse(str.Substring(i, 1));

                if (!Char.IsLetter(letter) && i > 0)
                {
                    result = counter(result, str, i);
                    sb.Clear();
                }
                else
                {
                    sb.Append(letter);
                }
            }
            result = counter(result, str, str.Length);
            return result;
        }

        public static int counter(int cnt, string str, int i)
        {
            Char pletter = Char.Parse(str.Substring(i - 1, 1));
            if (pletter == 'y' || pletter == 'x')
                cnt++;
            return cnt;
        }



        //Refactored Solution
        public static int countYZ_Sol2(string str)
        {
            Char fchar, nchar, lchar;
            str = str.ToLower();
            int result = 0;
            if (str.Length == 0)
                return result;

            for (int i = 0; i < str.Length - 1; i++)
            {
                fchar = Char.Parse(str.Substring(i, 1));
                nchar = Char.Parse(str.Substring(i + 1, 1));

                if ((fchar == 'x' || fchar == 'y') && !Char.IsLetter(nchar))
                    result++;
            }

            lchar = Char.Parse(str.Substring(str.Length - 1, 1));
            if ((lchar == 'x' || lchar == 'y'))
                result++;

            return result;
        }

    }
}
