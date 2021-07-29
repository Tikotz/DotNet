using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intarfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TV T = new TV();
            OnClickPowerBotton(T);
            Computer comp = new Computer();
            OnClickPowerBotton(comp);
            Phone phone = new Phone();
            OnClickPowerBotton(phone);

        }

           
        public static void OnClickPowerBotton(IOnabale onable)
        {
            onable.On();
        }
    }

    
    public class TV : IOnabale
    {
        public void On()
        {
            Console.WriteLine("This TV ON");
        }
    }
    public class Computer : IOnabale
    {
        public void On()
        {
            Console.WriteLine("This computer is ON");
        }
    }
    public class Phone : IOnabale
    {
        public void On()
        {
            Console.WriteLine("This Phone is ON");
        }
    }

    interface IOnabale
    {
        void On();
    }
}
