using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectEF
{
    
    public class Shape
    {


        public int[,] Size;
        public string Color;
        public char TheChar { get; set; } = '@';

        public int Location;

        public void GenarateShape(char ch, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(ch);
            }
        }
    }
    public class Line : Shape
    {
        
        public char MyChar { get; set; } = '=';
    }

    public class Square : Shape
    {
        public void GenarateShape(char ch, int hight, int width)
        {
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(ch);
                    
                }
                Console.WriteLine();
                
            }
        }
        public char MyChar { get; set; } = '&';
    }

    public class Rectangle : Shape
    {
        public char MyChar { get; set; } = '&';
    }
    public class Triangular : Shape
    {
        public char MyChar {  get; set; } = '#';
    }


}
