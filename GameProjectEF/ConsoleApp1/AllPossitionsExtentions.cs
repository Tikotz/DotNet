using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class AllPossitionsExtentions
    {
        public static bool ShapeIsTher(this bool[,] bigArray, bool[,] smallArray)
        {
            for (int i = 0; i < smallArray.GetLength(0); i++)
            {
                for (int j = 0; j < smallArray.GetLength(1); j++)
                {
                    if (bigArray[i, j] == true && smallArray[i, j] == true)
                    {
                        return false;
                    }
                    else if(bigArray[i, j] == true && smallArray[i, j] == false)
                    {
                        continue;
                    }
                    bigArray[i, j] = smallArray[i, j];
                }
            }
            return true;
        }

        public static void clearArray(this bool[,] bigArray)
        {
            for (int i = 0; i < bigArray.GetLength(0); i++)
            {
                for (int j = 0; j < bigArray.GetLength(1); j++)
                {
                    bigArray[i,j] = false;
                }
            }
        }
    }


}
