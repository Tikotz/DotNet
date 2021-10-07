using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class AllPossitionsExtentions
    {
        public static bool ShapeIsThere(this bool[,] bigArray, bool[,] smallArray)
        {
            for (int i = 0; i < smallArray.GetLength(0); i++)
            {
                for (int j = 0; j < smallArray.GetLength(1); j++)
                {
                    if (bigArray[i, j] && smallArray[i, j])
                    {
                        return false;
                    }
                    //if (bigArray[i, j] == true && smallArray[i, j] == true)
                    //{
                    //    return false;
                    //}
                    else if (bigArray[i, j] == true && smallArray[i, j] == false)
                    {
                        continue;
                    }
                    bigArray[i, j] = smallArray[i, j];
                }
            }
            return true;
        }

        public static void DrawBoardWithShape(this bool[,] bigArray, bool[,] smallArray)
        {
            Console.Clear();

            for (int i = 0; i < smallArray.GetLength(0); i++)
            {
                for (int j = 0; j < smallArray.GetLength(1); j++)
                {
                    var num = Convert.ToInt32(bigArray[i, j]) + Convert.ToInt32(smallArray[i, j]) * 2; // 0=all false, 1 = board only, 2 = shape only, 3 = conflict
                    Console.SetCursorPosition(i, j);

                    switch (num)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("#");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("*");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("x");
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.ReadLine();
        }

        public static void clearArray(this bool[,] bigArray)
        {
            for (int i = 0; i < bigArray.GetLength(0); i++)
            {
                for (int j = 0; j < bigArray.GetLength(1); j++)
                {
                    bigArray[i, j] = false;
                }
            }
        }
    }


}
