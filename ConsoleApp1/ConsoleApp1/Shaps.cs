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
        Random r { get; set; }

        bool[,] Size { get; set; }
        char MyChar { get; set; }

        void ChooseColor();

        void GenarateShape();
        
       
    }
    public class Line : Shape
    {
        public Random r { get; set; } = new Random();

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
            int size = r.Next(2, 11);
            int num1 = r.Next(1, 79);
            int num2 = r.Next(1, 24);
            Console.SetCursorPosition(num1, num2);
            for (int i = 0; i < size; i++)
            {
                if (num1 + i >= 80 || num2 >= 25)
                {
                    break;
                }

                Size[num1 + i, num2] = true;
                Console.Write(MyChar);
            }
        }
    }

    public class Square : Shape
    {
        public Random r { get; set; } = new Random();

        public bool[,] Size { get; set; } = new bool[81, 26];
        public char MyChar { get; set; } = '&';

        public override string ToString()
        {
            return "Square";
        }
        public void ChooseColor()
        {
            Console.ForegroundColor = (ConsoleColor)r.Next(7, 14);
        }
        public void GenarateShape()
        {
            Size.clearArray();
            int size = r.Next(3, 11);

            int num1 = r.Next(1, 79);
            int num2 = r.Next(1, 24);

            Console.SetCursorPosition(num1, num2);
            for (int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(num1, num2 + i);
                for (int j = 0; j < size; j++)
                {

                    if (num1 + j < 80 && num2 + i < 25)
                    {
                        Size[num1 + j, num2 + i] = true;
                        Console.Write(MyChar);
                    }
                }
            }
        }
    }

    public class Rectangle : Shape
    {
        public Random r { get; set; } = new Random();

        public char MyChar { get; set; } = '@';

        public bool[,] Size { get; set; } = new bool[81, 26];
        public override string ToString()
        {
            return "Rectangle";
        }
        public void ChooseColor()
        {
            Console.ForegroundColor = (ConsoleColor)r.Next(7, 14);
        }
        public void GenarateShape()
        {
            Size.clearArray();
            int hight = r.Next(3, 11);
            int width = r.Next(2, 11);
            int num1 = r.Next(1, 79);
            int num2 = r.Next(1, 24);

            Console.SetCursorPosition(num1, num2);
            for (int i = 0; i < hight; i++)
            {
                Console.SetCursorPosition(num1, num2 + i);
                for (int j = 0; j < width; j++)
                {

                    if (num1 + j < 80 && num2 + i < 25)
                    {
                        Size[num1 + j, num2 + i] = true;
                        Console.Write(MyChar);
                    }
                }
            }
        }

    }
    public class Triangular : Shape
    {
        public Random r { get; set; } = new Random();
        public bool[,] Size { get; set; } = new bool[81, 26];
        public char MyChar { get; set; } = '#';
        public void ChooseColor()
        {
            Console.ForegroundColor = (ConsoleColor)r.Next(7, 14);
        }
        public override string ToString()
        {
            return "Triangular";
        }
        public void GenarateShape()
        {
            Size.clearArray();
            int trihight = r.Next(2, 10);
            int num1 = r.Next(1, 79);
            int num2 = r.Next(1, 24);

            Console.SetCursorPosition(num1, num2);

            for (int i = 1; i < trihight; i++)
            {
                Console.SetCursorPosition(num1, num2 + i);

                for (int j = 0; j < i; j++)
                {
                    if (num1 + j < 80 && num2 + i < 25)
                    {
                        Size[num1 + j, num2 + i] = true;
                        Console.Write(MyChar);
                    }
                }
            }
        }
    }

}
