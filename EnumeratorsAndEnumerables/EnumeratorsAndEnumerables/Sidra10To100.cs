using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Sidra10To100 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i * 10;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

