using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAndFiles1
{
    public class Car
    {
        public string Id { get; set; }
        public string Brand { get; set; }

        public static List<Car> Cars = new List<Car>();

        public string ToCSV()
        {
            string str;
            str = string.Format("Id ={0},Brand = {1}", Id, Brand);
            return str;
        }
        public string ToFixedLength()
        {
            var str1 = "";
            str1 = string.Format("{0:2}{1:5}", Id, Brand);
            return str1;
        }

    }
}
