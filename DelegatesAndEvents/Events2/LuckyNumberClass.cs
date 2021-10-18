using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    public class LuckyNumberClass
    {
        public void Lucky()
        {
            Console.WriteLine("Enter number: ");
            var number = int.Parse(Console.ReadLine());
            while (number != 999)
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
            }
            if(LuckyNumberWasEntered != null)
            {
                LuckyNumberWasEntered();
            }
        }
        public event SimpleDelegate LuckyNumberWasEntered;


    }
}
