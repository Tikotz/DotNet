using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Table
    {
        public string Manufacturer { get; } = "IKEA";

        public string Color { get; private set; }

        public int Price;

        public Table(string color)
        {
            
            Color = color;
        }

    }
}
