using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    interface IFlyable
    {
        void fly();
        double GetAttitude(double attitude);
    }
}
