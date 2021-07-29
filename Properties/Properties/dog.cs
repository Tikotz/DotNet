using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class dog : IAnimal,IMakeSundable
    {
        public void Eat()
        {
            Console.WriteLine("Yami");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzz");
        }
        public void Move()
        {
            Console.WriteLine("I dont move i Run!!");
        }
        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("bark... bark...");
            Eat();
        }
    }
}
