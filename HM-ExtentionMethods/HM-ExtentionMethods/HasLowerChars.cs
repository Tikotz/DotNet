using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ExtentionMethods
{
    static class StringExtentionMethod
    {
        static public bool HasLowerChar(this string str)
        {
            int count = 0;
            foreach (char item in str)
            {
                if (str.Any(char.IsLower))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public static string ReverseCase(this string str)
        {
            string newStr = "";
            foreach (var ch in str)
            {
                if (char.IsUpper(ch))
                {
                    newStr += char.ToLower(ch);
                }
                else
                {
                    newStr += char.ToUpper(ch);
                }
            }

            return newStr;

            
            //foreach (var ch in str)
            //{
            //    if (char.IsUpper(ch))
            //    {
            //        ch = char.ToLower(ch);
            //    }
            //    else
            //    {
            //        ch = char.ToUpper(ch);
            //    }
            //}

            //return str;
        }
    }
}
