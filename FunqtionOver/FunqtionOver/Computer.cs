using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunqtionOver
{
    class Computer
    {
        //fields - members
        public string[] AllOpenFiles;
        public bool isTurnOn;

        public Computer()
        {
                
        }
        //Ctors
        public Computer(string[] AllFiles)
        {
            isTurnOn = true;
            AllOpenFiles = AllFiles;
        }


        //Methods
        public void TurnOff()
        {
            AllOpenFiles = null;
            isTurnOn = false;

        }

        public void TurnOff(bool forceOff)
        {
            if(AllOpenFiles == null)
            {
                TurnOff();
            }
            else
            {
                Console.WriteLine("are you sure? y/n");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "y")
                {
                    TurnOff();
                }
            }
        }
    }
}
