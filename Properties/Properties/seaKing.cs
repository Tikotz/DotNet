using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class SeaKing : IAnimal,IMakeSundable
    {
        public void Eat()
        {
            Console.WriteLine("Where is Shiraushi");
        }
        public void Sleep()
        {
            Console.WriteLine("we dont sleep");
        }
        public void Move()
        {
            Console.WriteLine("I dont move i swim only in the GrandLine!!");
        }
        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("I can eat everything !");
            Eat();
        }


    }
}
