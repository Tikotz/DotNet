using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/** Board
 * - It's an arrey.
 * - It takes width and height
 * - The width is where you break-line when you render
 * 
 * **/
namespace ConsoleApp1
{
    class Board : MainGame
    {
        char[,] BoardArray = new char[81, 26];
        

        private char widthBorder { get; set; } = '-';
        private char heightBorder { get; set; } = '|';
        public void CreateBoard()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < BoardArray.Length; i++)
            {
                if (i == 0 || i == 25)
                {
                    for (int j = 0; j < BoardArray.GetLength(0); j++)
                    {
                        BoardArray[j,i] = widthBorder;
                        Console.Write(BoardArray[j,i]);
                    }
                    Console.WriteLine();
                }
                
                else
                {

                    for (int j = 0; j < BoardArray.GetLength(0); j++)
                    {
                        if (j == 0 || j == 80 && i == 1)
                        {
                            try
                            {
                                BoardArray[j, i] = heightBorder;
                                Console.Write(BoardArray[j, i]);
                                Console.WriteLine();
                            }
                            catch (Exception)
                            {

                                continue;
                            }

                        }
                    }
                }
            }
        }


    }
}
