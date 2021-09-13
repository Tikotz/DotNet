using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HM_Generics
{
    public static class StringExtensions
    {
        /*
        \d = digit
        \D = AlfaBeta
        . = Any char

        [^abc]
        [A - z]
        [A - Z]
        [a - z]
        *************************
        "a+" = one or more times
        "a*" = zero or more times
        "a{5"} = 5 times
        "a{3,25}" = repits between 3 to 25 times
        "^D.*" = string that start with D

        
        */
        static string myExpression = @"\d\d";




        public static bool IsValidName(this string name)
        {
            var regex = new Regex(@"\D{2,50} \D{0,50}");
            return regex.IsMatch(name);
            //if (name.Length < 2) return false;
            //foreach (var charactar in name)
            //{
            //    if (charactar < 'A' || charactar > 'z' || charactar == '\'')
            //    {
            //        return false;
            //    }

            //}
            //return true;
        }

        public static bool IsIlIdentity(this string name)
        {
            var expression = @"\d{9}";
            var regex = new Regex(expression);
            return regex.IsMatch(name);
            //if (name.Length != 9) return false;
            //foreach (var charactar in name.PadLeft(9, '0'))
            //{
            //    if (charactar < '0' || charactar > '9')
            //    {
            //        return false;
            //    }

            }
            //return true;
        }


    }
    
}
