using System;
using System.Threading.Tasks;

namespace Tasks0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 13;
            Task.Run(() => Console.WriteLine(num = num * 2 + 3));
            Task.Factory.StartNew(() => Console.WriteLine(num = num + num - 3));

            //use regulrly
            Task.Run(() => Console.WriteLine(num = num * 2 + 3));

            Task<string> task1 = Task.Factory.StartNew(() => { return DateTime.Now.ToString(); });

            //task1.wait();
            Task.WaitAny(task1);
            Console.WriteLine(task1.Result);
        }
    }
}
