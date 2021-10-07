using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Shape
    {

        bool[,] Size { get; set; }
        char MyChar { get; set; }

        void ChooseColor();

        void GenarateShape();
        
       
    }
    public class Line : Shape
    {
        Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

        public bool[,] Size { get; set; } = new bool[81, 26];
        public char MyChar { get; set; } = '=';

        public void ChooseColor()
        {
            Console.ForegroundColor = (ConsoleColor)r.Next(7, 14);
        }
        public override string ToString()
        {
            return "Line";
        }
        public void GenarateShape()
        {
            Size.clearArray();
            int size = r.Next(2, 10);
            int posX = r.Next(1, 79);
            int posY = r.Next(1, 24);

            if (posY >= 25)
                return;

            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < size; i++)
            {
                posX++;

                if (posX>= 80)
                {
                    break;
                }

                Size[posX, posY] = true;
                Console.Write(MyChar);
            }
        }
    }

    public class Square : Shape
    {
        Random r1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

        public bool[,] Size { get; set; } = new bool[81, 26];
        public char MyChar { get; set; } = '&';

        public override string ToString()
        {
            return "Square";
        }
        public void ChooseColor()
        {
            Console.ForegroundColor = (ConsoleColor)r1.Next(7, 14);
        }
        public void GenarateShape()
        {
            Size.clearArray();
            int size = r1.Next(3, 10);
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
                        Size[posX + j, posY + i] = true;
                        Console.Write(MyChar);
                    }
                }
            }
        }
    }

    public class Rectangle : Shape
    {
        Random r2 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        public char MyChar { get; set; } = '@';

        public bool[,] Size { get; set; } = new bool[81, 26];
        public override string ToString()
        {
            return "Rectangle";
        }
        public void ChooseColor()
        {
            Console.ForegroundColor = (ConsoleColor)r2.Next(7, 14);
        }
        public void GenarateShape()
        {
            Size.clearArray();
            int hight = r2.Next(3, 10);
            int width = r2.Next(2, 10);
            int num5 = r2.Next(1, 79);
            int num6 = r2.Next(1, 24);

            Console.SetCursorPosition(num5, num6);
            for (int i = 0; i < hight; i++)
            {
                Console.SetCursorPosition(num5, num6 + i);
                for (int j = 0; j < width; j++)
                {

                    if (num5 + j < 80 && num6 + i < 25)
                    {
                        Size[num5 + j, num6 + i] = true;
                        Console.Write(MyChar);
                    }
                }
            }
        }

    }
    public class Triangular : Shape
    {
        Random r3 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        public bool[,] Size { get; set; } = new bool[81, 26];
        public char MyChar { get; set; } = '#';
        public void ChooseColor()
        {
            Console.ForegroundColor = (ConsoleColor)r3.Next(7, 14);
        }
        public override string ToString()
        {
            return "Triangular";
        }
        public void GenarateShape()
        {
            Size.clearArray();
            int trihight = r3.Next(2, 9);
            int num7 = r3.Next(1, 79);
            int num8 = r3.Next(1, 24);

            Console.SetCursorPosition(num7, num8);

            for (int i = 1; i < trihight; i++)
            {
                Console.SetCursorPosition(num7, num8 + i);

                for (int j = 0; j < i; j++)
                {
                    if (num7 + j < 80 && num8 + i < 25)
                    {
                        Size[num7 + j, num8 + i] = true;
                        Console.Write(MyChar);
                    }
                }
            }
        }
    }

}
