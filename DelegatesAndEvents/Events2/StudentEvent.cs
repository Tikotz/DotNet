using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    public class StudentEvent
    {
        public string Name { get; set; }
        public StudentEvent(string name)
        {
            Name = name;
        }
    }
}
