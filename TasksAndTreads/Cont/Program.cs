using System;
using System.Threading.Tasks;

namespace Cont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => DateTime.Now.Second).ContinueWith(tsk => Console.WriteLine(tsk.Result));
        }
    }
}
