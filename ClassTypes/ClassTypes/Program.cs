using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello from main");
            //string x = Computer.Type;
            VeihcleBase bugati = new Car("Bugati",4,3);
            VeihcleBase yamaha = new MotorCycle(2,"09 yamaha",2);
            Carrier ca = new Carrier(new VeihcleBase[4]);
            ca.Veihcles[0] = bugati;
            ca.Veihcles[1] = yamaha;
            Console.WriteLine(ca.ToString());
        }
    }
}
