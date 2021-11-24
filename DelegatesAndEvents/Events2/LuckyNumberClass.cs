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
            int count = 0;
            while (number != 999)
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
                
                    count++;
                
            }
            if(LuckyNumberWasEntered != null)
            {
                LuckyNumberWasEntered();
                Console.WriteLine($"you tried {count} times untill u won ");
            }
        }
        public event SimpleDelegate LuckyNumberWasEntered;


    }
}
