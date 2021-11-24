using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsHM
{
    internal class NumNum
    {
        public NumNum(string nameOfThread)
        {
            Random random = new Random();
            SleepTime = random.Next(1000,5000);
            NameOfThread = nameOfThread;
        }

        public int SleepTime { get; set; }
        public string NameOfThread { get; set; }

        public void Sleep()
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"{NameOfThread} going to sleep");
                Thread.Sleep(SleepTime);
                Console.WriteLine($"{NameOfThread} sleeping time over");
                Console.WriteLine($"Thread '{NameOfThread}' ; sleep time {SleepTime / 1000f} seconds");
            });
            thread.Start();
            thread.Join();
        }
    }
}
