using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            int[] vs = new int[] { 1, 2, 3 };
            foreach (var item in vs)
            {

            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 10);
            }

            foreach (var item in new Sidra10To100())
            {
                Console.WriteLine(item);
            }
        }
    }
}
