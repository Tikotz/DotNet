using System;
using System.Threading.Tasks;

namespace Async1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tsk = AsyncInner();
            Console.WriteLine("After call to inner");

            tsk.Wait();
        }
        static void Outer()
        {
            
            
        }
        static async Task<string> AsyncInner()
        {
            Console.WriteLine("start inner ");
            await Task.Run(() =>
            {

                Task.Delay(4000);
                //for (int i = 0; i < 100; i++)
                //{

                //    Console.WriteLine("Inner");
                //}
                return;
            });
            Console.WriteLine("end inner ");

        }
    }
}
