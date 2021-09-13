using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectEF
{


    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.ForegroundColor = ConsoleColor.White;
            //Console.SetCursorPosition(1, 1);
            //Console.Write('*');

            Random rnd = new Random();
            int LineSize = rnd.Next(2, 11);


            Line l1 = new Line();
            l1.GenarateShape(l1.MyChar, LineSize);
            Console.WriteLine();
            int SquareSize = rnd.Next(3,11);
            Square sq1 = new Square();
            sq1.GenarateShape(sq1.MyChar,SquareSize, SquareSize);
        }
    }
}
