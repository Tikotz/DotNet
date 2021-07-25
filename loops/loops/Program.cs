using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("enter a number: ");
            int x = int.Parse(Console.ReadLine());
            int i = 0;
            while(x < 20)
            {
                i += 1;
               Console.WriteLine(i);
                if (x % 2 == 0 && x > 14)
                {
                    int y = x / 2;
                    while (y > 0)
                    {
                        Console.WriteLine("inner loop: {0}", y);
                        y--;
                    }

                }
            x++;
            
            }*/

            //***************************

            /*int i;
            for (i = 2; i <= 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);

                    }
                }*/


            #region 3

            /*int i;
            int sum = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("enter a number: ");
                int x = int.Parse(Console.ReadLine());
                sum += x;
            }
            double memuza = sum / 5;
            Console.WriteLine(memuza);
            */
            #endregion
            #region 4
            /*do
            {
                    Console.WriteLine("enter number 1: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter number 2: ");
                    int y = int.Parse(Console.ReadLine());

                    if (x == 0 || y == 0)
                    {
                        continue;
                    }
                    else if (x < 0 || y < 0)
                    {
                        break;
                    }
                    else
                    {
                        int mult = x * y;
                        int sum = x + y;
                        Console.WriteLine("multiple = {0}, sum = {1}", mult, sum);
                    }
                }
                while (true);*/
            #endregion

            #region 0-9,0-8

            //for (int i = 10; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region multi

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}