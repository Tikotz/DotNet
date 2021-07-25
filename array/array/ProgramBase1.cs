using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class ProgramBase1
    {
        static void Main(string[] args)
        {
            #region array1
            //int[] myintarray = new int[10] { 2, 5, 8, 13, 15, 18, 20, 22, 26, 43 };
            //for (int i = 0; i < myintarray.Length; i++)
            //{


            //    if (myintarray[i] % 2 == 0)
            //    {
            //        Console.WriteLine(myintarray[i]);
            //    }
            //}
            #endregion

            #region array2
            int[] myintarray1 = new int[10];
            int[] myintarray2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("please enter first value: ");
                int val1 = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter second value: ");
                int val2 = int.Parse(Console.ReadLine());
                myintarray1[i] = val1;
                myintarray2[i] = val2;

            }
            for (int i = 0; i < 10; i++)
            {
                if (myintarray1[i] < myintarray2[i])
                {
                    Console.WriteLine(myintarray2[i]);
                }

                else
                {
                    Console.WriteLine(myintarray1[i]);

                }
            }
            #endregion
        }
    }
}