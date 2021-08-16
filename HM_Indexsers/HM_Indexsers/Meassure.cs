using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Indexsers
{
    class Meassure
    {

        public string Location { get; set; }
        public int Date { get; set; }
        public double Temp { get; set; }
    }
    class ManageMeassure
    {
        Wather w2 = new Wather();
        private Meassure[] m1 = new Meassure[28];
        
        public ManageMeassure()
        {
            for (int i = 0,k = 1; i < m1.Length; i++,k++)
            {
                m1[i].Date = k;
                m1[i].Location = $"L {k}";
                m1[i].Temp = w2.Tempertures[i, 0];
            }
        }
        public Meassure this[int day]
        {
            get { return m1[day - 1]; }
            set { m1[day - 1] = value; }
        }

        public double? this[string city]
        {
            get 
            {
                for (int i = 0; i < m1.Length; i++)
                {
                    if (m1[i].Location == city)
                    {
                        return m1[i].Temp;
                    }
                }
                return null;
            }
            
        }
    }
}
