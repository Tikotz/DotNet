using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    public class Shape
    {
        public bool[,] AllPossitions = new bool[81, 26];

        public int Length { get; set; }

        public char MyChar {  get; set; }


        Random r1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);


        public void GenarateShape(int size)
        {
                int posX = r1.Next(1, 79);
                int posY = r1.Next(1, 24);

                Console.SetCursorPosition(posX, posY);
                for (int i = 0; i < size; i++)
                {
                    if (posY + i >= 25)
                        return;
                    Console.SetCursorPosition(posX, posY + i);
                    for (int j = 0; j < size; j++)
                    {
                        if (posX + j < 80)
                        {
                            AllPossitions[posX + i, posY + j] = true;
                            Console.Write("#");
                        }
                    }
                }
            
        }
        public void BallMove(ref int X, ref int Y)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X, Y);
            ConsoleKeyInfo move;
            move = Console.ReadKey(true);
            switch (move.Key)
            {
                case ConsoleKey.LeftArrow:
                    Console.SetCursorPosition(X, Y);
                    Console.Write("*");
                    X--;
                    break;
                case ConsoleKey.UpArrow:
                    Console.SetCursorPosition(X, Y);
                    Console.Write("*");
                    Y--;
                    break;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(X, Y);
                    Console.Write("*");
                    X++;
                    break;
                case ConsoleKey.DownArrow:
                    Console.SetCursorPosition(X, Y);
                    Console.Write("*");
                    Y++;
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(X, Y);
            Console.Write("*");
        }
        public static event SimpleDelegate Outch;

    }

}
