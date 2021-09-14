using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ball
    {
        public char MyChar { get; set; } = '*';

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
                    Console.Write(MyChar);
                    X--;
                    break;
                case ConsoleKey.UpArrow:
                    Console.SetCursorPosition(X, Y);
                    Console.Write(MyChar);
                    Y--;
                    break;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(X, Y);
                    Console.Write(MyChar);
                    X++;
                    break;
                case ConsoleKey.DownArrow:
                    Console.SetCursorPosition(X, Y);
                    Console.Write(MyChar);
                    Y++;
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(X, Y);
            Console.Write(MyChar);
        }
    }
}
