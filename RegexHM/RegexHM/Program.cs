using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexHM
{
    class Program
    {
        static void Main(string[] args)
        {
            #region basic1
            Regex reg1 = new Regex(@"^[D]");
            string print1 = "David";
            Console.WriteLine(reg1.IsMatch(print1));
            #endregion

            #region basic2
            Regex reg2 = new Regex(@"^[JFD]");
            string print2 = "Jefar";
            Console.WriteLine(reg2.IsMatch(print2));
            #endregion

            #region basic3
            Regex reg3 = new Regex(@"^[JFD]\d{6}[-]\D{2}");
            string print3 = "F123456-DD";
            Console.WriteLine(reg3.IsMatch(print3));
            #endregion
            #region basic4
            string reg4 = @"([y{3}|z{5}])";
            string print4 = "yyyorzzzzz";
            print4 = Regex.Replace(print4, reg4, "");
            Console.WriteLine(print4);
            #endregion
            #region basic5
            Regex reg5 = new Regex(@"^[A-Z]");
            string print5 = "Elsf";
            Console.WriteLine(reg5.IsMatch(print5));
            #endregion
            #region 1
            //string str1 = "abcjdadABC";
            //Regex Contanin_abc = new Regex(@"(abc)||(ABC)");
            //var unswer = Contanin_abc.IsMatch(str1);
            //Console.WriteLine(unswer);
            #endregion
            #region 2
            //string Me = "Ori Tikozki";
            //Regex IsValidName = new Regex(@"\D{2,18} \D{2,18}");
            //var result = IsValidName.IsMatch(Me);
            //Console.WriteLine(result);
            #endregion
            #region 3
            //string num = "69.69";
            //Console.WriteLine(IsDecimal(num));
            #endregion
            #region 4
            //string num1 = "6.214";
            //Console.WriteLine(IsDemicalWithOnly3Digits(num));
            #endregion
            #region 5
            //string Email = "Oritiko@gmail.com";
            //string Email2 = "Oritiko@Gmail.com";
            //string Email3 = "Oritiko@yahoo.com";
            //string Email5 = "Oritiko@fdsaf.com";
            //string Email4 = "Oritiko@YAHOO.COM";
            //Console.WriteLine(IsEmailValid(Email));
            //Console.WriteLine(IsEmailValid(Email2));
            //Console.WriteLine(IsEmailValid(Email3));
            //Console.WriteLine(IsEmailValid(Email4));
            //Console.WriteLine(IsEmailValid(Email5));
            #endregion
        }
        public static bool IsDecimal(string num)
        {
            string pattern = @"^[0-9]*\.[0-9]+$";
            return Regex.Match(num, pattern).Success;
        }
        public static bool IsDemicalWithOnly3Digits(string num)
        {
            string pattern = @"^[0-9]*\.\d{1,3}$";
            return Regex.Match(num, pattern).Success;
        }
        public static bool IsEmailValid(string mail)
        {
            string pattern = @"[A-z0-9.]\@(gmail|yahoo|GMAIL|YAHOO|Gmail|Yahoo)\.(com|COM)$";
            return Regex.Match(mail, pattern).Success;
        }
    }
}
