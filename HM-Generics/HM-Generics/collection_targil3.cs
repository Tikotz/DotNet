using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Generics
{
    interface BLOOP<T>
    {
        public string GetType(T type);
    }
    class collection_targil3<T> : BLOOP<T>
    {
        public string GetType(T type)
        {
            return type.GetType().ToString();
        }
    }
}
