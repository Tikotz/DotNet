using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string Language { get; set; } = "en-US";
        public static void PrintHello()
        {
            Console.WriteLine("Hello!");
        }
        public static void PrintShalom()
        {
            Console.WriteLine("Shalom!");
        }

        public delegate void PrintSomthing();

        public static PrintSomthing ReturnGreetingMethod(string language)
        {

            switch (Language)
            {
                case "en-US":
                    return PrintHello;
                case "he-IL":
                    return PrintShalom;
                default:
                    return null;
            }
        }
        static void Main(string[] args)
        {
            PrintSomthing greet = PrintHello;

            PrintSomthing greet1 = ReturnGreetingMethod("en-US");

            greet();
        }
    }
}
