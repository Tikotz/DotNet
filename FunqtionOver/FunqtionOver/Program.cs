using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunqtionOver
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tirgulim
            //PrintInTwoRows(true,false);
            //calculator cal = new calculator();
            //Console.WriteLine(cal.calcints(2, 3, '*'));

            //Console.ReadLine();
            #endregion

            #region HM 1
            //watch DgWatch = new watch();
            //DgWatch.PrintHourAndMinute();
            //DgWatch.PrintHourAndMinuteAndSec();
            //DgWatch.PrintHourMinuteSecondsDayAndTemperture();
            //DgWatch.PrintDetails(10,30);
            #endregion

            #region HM8
            Computer c = new Computer();
            SmartComp sc = new SmartComp();
            c.TurnOff();
            sc.TurnOff();
            #endregion
        }

        public static void PrintInTwoRows(string str1, string str2)
        {
            Console.WriteLine(str1 + str2);
        }

        public static void PrintInTwoRows(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void PrintInTwoRows(bool b1, bool b2)
        {
            Console.WriteLine(b1 + "\n" + b2);
        }

    }

    class calculator
    {
        public int calcints(int n1, int n2, char ch1)
        {
            switch (ch1)
            {
                case '+':
                    return n1 + n2;

                case '-':
                    return n1 - n2;

                case '*':
                    return n1 * n2;
            }
            return -000;

        }
    }

    class watch
    {

        public int hour;
        public int min;
        public int sec;
        public int day;
        public int temp;

        
        public watch()
        {
            DateTime date = DateTime.Now;
            this.hour = date.Hour;
            this.min = date.Minute;
            this.sec = date.Second;
            this.day = date.Day;
            this.temp = 31;

        }
        public void PrintHourAndMinute()
        {
            Console.WriteLine(hour + ":" + min);
        }

        public void PrintHourAndMinuteAndSec()
        {
            Console.WriteLine(hour + ":" + min + ":" + sec);
        }
        public void PrintHourMinuteSecondsDayAndTemperture()
        {
            Console.WriteLine(hour + ":" + min + ":" + sec + ":" + day + ":" + temp);
        }
        public void PrintDetails(int hour,int min)
        {
            Console.WriteLine(hour + ":" + min);
        }

        public void PrintDetails(int hour, int min,int sec)
        {
            Console.WriteLine(hour + ":" + min + ":" + sec);
        }
        public void PrintDetails(int hour, int min, int sec,int day,int temp)
        {
            Console.WriteLine(hour + ":" + min + ":" + sec + ":" + day + ":" + temp);
        }

       
    }

    
       

}