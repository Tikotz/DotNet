using com.sun.tools.jdi;
using java.lang;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using Thread = System.Threading.Thread;

namespace ThreadsHM
{
    internal class Program
    {

        

        
        static void Main(string[] args)
        {

            #region 1-2

            // Thread thread1 = new Thread(() =>
            //{
            //    var directoty1 = Directory.GetDirectories(@"C:\Users\ori\Documents\workspace");
            //    foreach (var dir in directoty1)
            //    {
            //        Console.WriteLine(dir);
            //    }
            //});
            // Thread thread2 = new Thread(() =>
            // {
            //     var directoty1 = Directory.GetDirectories(@"C:\Users\ori\Documents");
            //     foreach (var dir in directoty1)
            //     {
            //         Console.WriteLine(dir);
            //     }
            // });
            // thread1.Start();
            // thread2.Start();

            // thread2.Join();
            // thread1.Join();
            #endregion
            #region 3
            NumNum Person1 = new NumNum("lior Is The Best");
            NumNum Person2 = new NumNum("Or The Seller");
            NumNum Person3 = new NumNum("Avichi The Anime Guy");
            NumNum Person4 = new NumNum("Gil The Teacher");

            Console.WriteLine("Start\n");

            //Person1.Sleep();
            //Person2.Sleep();
            //Person3.Sleep();
            //Person4.Sleep();
            //Console.WriteLine("\nWe done sleeping");
            #endregion

            #region 4
            Console.WriteLine("enter number above 1 milion");
            double num = double.Parse(Console.ReadLine());
            SumClass sumClass = new SumClass(1,num);
            double divnum = num / 200000;

            for (double i = 0; i < divnum; i++)
            {
                var t4 = new Thread(sumClass.SumTo200K);
                t4.Start();
                t4.Join();

            }
            #endregion


        }
    }
}
