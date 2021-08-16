using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Indexsers
{
    class Wather
    {
        public double[,] Tempertures { get; set; } = new double[28, 1];

        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
        public Wather()
        {
            for (int i = 0; i < Tempertures.Length; i++)
            {
                Tempertures[i, 0] = System.Math.Round(RandomNumberBetween(24, 40), 2);
            }
        }
        public double this[int i]
        {
            get { return Tempertures[i,0]; }
            set {  Tempertures[i,0] = value; }
        }
        public double GetWather(string day)
        {
            try
            {
                int num = int.Parse(day);
                return Tempertures[num - 1, 0];
            }
            catch
            {
                return 0000;
            }
        }
    }
}

