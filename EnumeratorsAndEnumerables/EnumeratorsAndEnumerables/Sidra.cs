using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Sidra : IEnumerable<double>
    {
        public double num { get; set; }
        public int secnum { get; set; }

        public Sidra(int num)
        {
            this.num = num;
            this.secnum = num;
        }

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                num = num * secnum ;
                yield return num;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
