using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsHM
{
    public class SumClass
    {
        public double StartNumber { get; set; }
        public double EndNumber { get; set; }
        public double Sum { get; set; }
        static object LockObject = new object();

        public SumClass(double startNumber, double endNumber)
        {
            StartNumber = startNumber;
            EndNumber = endNumber;
        }

        public void SumNumbers(double num)
        {
            lock (LockObject)
            {
                Sum = Sum + num;
            }
        }
        
        public void SumTo200K()
        {
            for (int i = 1; i <= 200000; i++)
            {
                SumNumbers(StartNumber);
                StartNumber++;
            }
            Console.WriteLine("sum = " + Sum);
        }
    }
}
