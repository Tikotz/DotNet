using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class fish : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("bloop bloop");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzz");
        }
        public void Move()
        {
            Console.WriteLine("I dont move i swim!!");
        }
    }
}
