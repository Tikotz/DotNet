using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_And_Catch
{
    interface IGarage
    {
        void AddCar(Car car);
        void TakeOutCar(Car[] cars);
        void FixCar(Car[] cars);
    }
}
