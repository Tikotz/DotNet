using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_And_Catch
{
    class Car
    {
        public string Brand { get; set; }
        public bool TotalLoss { get; set; }
        public bool NeedRepair { get; set; }

        public Car(string brand, bool totalLoss, bool needRepair)
        {
            Brand = brand;
            TotalLoss = totalLoss;
            NeedRepair = needRepair;
        }
    }
}
