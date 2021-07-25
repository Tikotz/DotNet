using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
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
            //int[] myintarray1 = new int[10];
            //int[] myintarray2 = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("please enter first value: ");
            //    myintarray1[i] = int.Parse(Console.ReadLine());
            //    myintarray2[i] = myintarray1[i];
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (myintarray1[i] < myintarray2[i])
            //    {
            //        Console.WriteLine($"number 2 is bigger: {myintarray2[i]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"number 1 is bigger: {myintarray1[i]}");

            //    }
            //}
            #endregion


            #region homework1
            //int[] numbers = new int[10];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("enter number: ");
            //    int num = int.Parse(Console.ReadLine());
            //    numbers[i] += num;

            //}
            //for (int i = 9; i >= 0; i--) 
            //{
            //    Console.WriteLine("\n" + numbers[i]);
            //}
            #endregion

            #region homework2
            //int[] array = { 2, 4, 6, 8, 10 };
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[3]);
            //Console.WriteLine(array[4]);
            #endregion

            #region homework3
            //int[] array1 = new int[10];
            //int[] array2 = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("enter number: ");
            //    array1[i] = int.Parse(Console.ReadLine());
            //    array2[i] = array1[i];
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(array1[i]);
            //    Console.WriteLine(array2[i]);
            //}
            //array1[0] = 8;
            //array1[9] = 88;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(array1[i]);
            //    Console.WriteLine(array2[i]);
            //}

            #endregion

            #region homework6
            //Console.WriteLine("enter the number of your studnts: ");
            //int num = int.Parse(Console.ReadLine());
            //int[] students_grade = new int[num];
            //int grade;
            //for (int i = 0; i < students_grade.Length; i++)
            //{
            //    Console.WriteLine("enter the student grade: ");
            //    grade = int.Parse(Console.ReadLine());
            //    students_grade[i] = grade;
            //}
            //int sum = 0;
            //double memuza = 0;
            //for (int i = 0; i < students_grade.Length; i++)
            //{
            //    sum += students_grade[i];
            //}
            //memuza = sum / students_grade.Length;
            //Console.WriteLine(sum);
            //Console.WriteLine(memuza);
            #endregion

            #region DemArr
            //int[,] myDemArray = new int[10, 10];
            //for (int i = 0; i < myDemArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myDemArray.GetLength(1); j++)
            //    {
            //        myDemArray[i,j] = (i + 1) * (j + 1);
            //        Console.Write(myDemArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region homework2 array2
            //int[] straraay = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //int trys = 0;
            //int good_unswere = 0;
            //for (int i = 0; i < straraay.Length; i++)
            //{
            //    int try1 = 0;
            //    while (trys <= 30)
            //    {
            //        try1++;
            //        Console.WriteLine("enter a number: ");
            //        int num = int.Parse(Console.ReadLine());
            //        if (Array.IndexOf(straraay, num) == i)
            //        {
            //            Console.WriteLine("you found the first number after {0} trys", try1);
            //            Console.WriteLine("now try to find the next number");
            //            good_unswere += 1;
            //            break; 
            //        }
            //        else
            //        {
            //            Console.WriteLine("wrong unswere try again...");
            //            trys += 1;
            //            continue;
            //        }
            //    }
            //}
            //if (good_unswere == (straraay.Length))
            //{
            //    Console.WriteLine("grate job you finished the game after {0} trys", trys);
            //}
            //else
            //{
            //    Console.WriteLine("GAME OVER");
            //}
            #endregion

            #region homework3 array2
            int[,] myarr = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 3, 6, 4, 8, 10 }, { 4, 2, 5, 3, 6 }, { 9, 1, 4, 2, 5 }, { 5, 6, 7, 8, 9 } };
            Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < myarr.GetLength(0); i++)
            {
                for (int j = 0; j < myarr.GetLength(1); j++)
                {
                    if (myarr[i, j] == num)
                    {
                        Console.WriteLine("the number was found in raw {0} and column {1}", i, j);
                    }
                }
            }
            #endregion

            #region homework7 array2
            //int[,] arr6 = new int[6, 4];
            //string star = "*";
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int x = 0; x < arr6.GetLength(1); x++)
            //    {
            //        Console.Write(star);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region homework6 array2
            //int[,,] haraarray = new int[2, 2, 2];
            //for (int i = 0; i < haraarray.GetLength(0); i++)
            //{
            //    for (int x = 0; x < haraarray.GetLength(1); x++)
            //    {
            //        for (int y = 0; y < haraarray.GetLength(2); y++)
            //        {
            //            Console.WriteLine("enter number from 1-10");
            //            int num = int.Parse(Console.ReadLine());
            //            haraarray[i, x, y] = num;

            //        }
            //    }
            //}
            //for (int i = 0; i < haraarray.GetLength(0); i++)
            //{
            //    for (int x = 0; x < haraarray.GetLength(1); x++)
            //    {
            //        for (int y = 0; y < haraarray.GetLength(2); y++)
            //        {
            //            Console.WriteLine(haraarray[i,x,y]);
            //        }
            //    }
            //}
            #endregion

            #region homework8 array2
            //int[][] superhara = new int[3][];
            //superhara[0] = new int[2];
            //superhara[1] = new int[2];
            //superhara[2] = new int[2]; 
            //for (int i = 0; i < superhara.Length; i++)
            //{
            //    for (int x = 0; x < superhara[i].Length; x++)
            //    {
            //        Console.WriteLine("enter number: ");
            //        superhara[i][x] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < superhara.Length; i++)
            //{
            //    for (int x = 0; x < superhara[i].Length; x++)
            //    {
            //        Console.WriteLine(superhara[i][x]);
            //    }
            //}

            #endregion
        }
    }
}
