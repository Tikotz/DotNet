using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Indexsers
{
    class Meassure
    {
        Wather w2 = new Wather();
        public string Location { get; set; }
        public int[] Date = new int[7]
        {
            1, 2, 3, 4, 5, 6, 7
        };
        
        public double Temp =   
        private Meassure[] m1 = new Meassure[6];

        public Meassure(string location, DateTime date, double temp)
        {
            Location = location;
            Temp = temp;
        }
        public Meassure this [int i]
        {
            get {  return m1[i]; } 
            set {  m1[i] = value; }
        }
    }
}
