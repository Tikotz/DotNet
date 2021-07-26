using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Table t1 = new Table("brown");
            t1.Price = 1000;
            string color = t1.Color;
            Console.WriteLine(color);
            
        }
    }
}
