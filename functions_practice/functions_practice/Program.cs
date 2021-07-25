using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region targil8
            //HM8();
            //Console.WriteLine("enter number from 1 - 10: ");
            //int num = int.Parse(Console.ReadLine());
            #endregion
            #region targil9
            //bool Q9 = HM9(num);
            //Console.WriteLine(Q9);
            #endregion
            #region targil 11
            //Console.WriteLine("enter number to check: ");
            //int number = int.Parse(Console.ReadLine());
            //int x = HM11(number);
            //Console.WriteLine(x);
            #endregion
            #region targil 12
            //int[] arr = { 17, 13, 9, 4, 2 };
            //HM12(arr);
            #endregion
            #region targil 13
            //int[] arr1 = { 1, 5, 3, 5, 10 };
            //int[] arr2 = { 2, 5, 3, 5, 10 };
            //int case1 = HM13(arr1, arr2);
            //Console.WriteLine(case1);
            #endregion
            #region targil 15
            int[] arrToSort = { 3, 6, 1, 15, -1 };
            int[] x  = HM15(arrToSort);
            #endregion 
        }
        public static void Function1(string word)
        {
            Console.WriteLine(word);
        }


        public static void HM8()
        {
            Console.WriteLine("enter number from 1 - 10: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 10)
            {
                switch (num)
                {
                    case 1:
                        {
                            Console.WriteLine("one");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("two");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("three");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("four");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("five");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("six");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("seven");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("eight");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("nine");
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("ten");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("number is out of range");
            }
        }

        public static bool HM9(int num)
        {
            if (num <= 10)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(i + 1);
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int HM11(int number)
        {
            if (number == 1)
            {
                return 0;
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return 0;
                    }

                }
                return 1;
            }
        }

        public static void HM12(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int x = 1; x <= arr[i]; x++)
                {
                    if (arr[i] % x == 0)
                    {
                        counter += 1;
                    }
                }
                if (counter > 2)
                {
                    Console.WriteLine(arr[i] + " this number is NOT Prime");
                }
                else
                {
                    Console.WriteLine(arr[i] + " this number is Prime");
                }
            }
        }

        public static int HM13(int[] arr1, int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                sum2 += arr2[i];
            }
            if (sum1 == sum2)
            {
                return 0;
            }
            else if (sum1 > sum2)
            {
                return 1;
            }
            else
            {
                return -1;
            }    
        }

        public static int[] HM15(int[] arrToSort)
        {
            int min;
            for (int i = 0; i < arrToSort.Length; i++)
            {
                min = arrToSort[i];
                for (int j = 0; j < arrToSort.Length; j++)
                {
                    if (arrToSort[j] < min)
                    {
                        min = arrToSort[j];
                    }
                }
                arrToSort[Array.IndexOf(arrToSort, min)] = arrToSort[i];
                arrToSort[i] = min;
            }
            return arrToSort;
        }
    }
}