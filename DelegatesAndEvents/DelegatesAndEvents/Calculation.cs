using System;

namespace DelegatesAndEvents
{
    public class Calculation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        
    }

    public delegate void CalcDelegate(int x, int y);
}
