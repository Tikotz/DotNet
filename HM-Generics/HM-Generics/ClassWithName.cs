using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Generics
{
    interface BaseName
    {
        public string Name { get; set; }
    }
    class ClassWithName
    {
        public string Name { get; set; } = "classic";
        public string printname()
        {
            return Name;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
