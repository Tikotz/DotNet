using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ExtentionMethods
{
    static class IntExtentionMethod
    {
        public static string Print(int num)
        {
            string[] numStr1 = { "", "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] numStr2 = { "teen", "twnty", "thirty", "fourty", "fifty", "sixsty", "siventy", "eghity", "ninty" };
            if (num >= 0 && num <= 10)
            {
                return numStr1[num + 1];
            }
            else if (num == 11)
            {
                return "elevem";
            }
            else if (num == 12)
            {
                return "twelve";
            }
            else if (num == 13)
            {
                return "thrteen";
            }
            else if (num < 20)
            {
                return $"{numStr1[num - 9]} {numStr2[0]}";
            }
            else if (num <= 100 && num % 10 == 0)
            {
                return $"{numStr2[num / 10 - 1]}";
            }
            else if (num <= 100)
            {
                return $"{numStr2[num / 10 - 1]} {numStr1[num % 10 + 1]}";
            }
            return "Ad Kan";
        }
        public static int MultipleBy(this int num, int input)
        {
            return num * input;
        }
    }
}
