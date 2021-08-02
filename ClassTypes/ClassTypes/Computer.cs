using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes
{
    static class Computer
    {

        static public string Type { get; set; }

        static Computer()
        {
            Type = "im static class";
            Console.WriteLine(Type);
        }

        static void On()
        {
            Console.WriteLine("its ON");
        }
        static void Off()
        {
            Console.WriteLine("its OFF");
        }
        
    }
}
