using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Generics
{
    class BaseProper
    {
        public string Id { get; set; }
    }
    class boss : BaseProper
    {
        public override string ToString()
        {
            return $"boss";
        }
    }
    class imploye : BaseProper
    {
        public override string ToString()
        {
            return $"imploye";
        }
    }
    class GenericID<T> where T : BaseProper
    {
        public int count { get; set; } = 1;
         T[] listid = new T[10];
        public void add(T data)
        {
            for (int i = 0; i < listid.Length; i++)
            {
                if (listid[i] == null)
                {
                    listid[i] = data;
                    listid[i].Id = $"{count}";
                    count++;
                    break;
                }
            }
        }
        public string sarchById(string id)
        {
            for (int i = 0; i < listid.Length; i++)
            {
                if (listid[i] != null)
                {
                    if (listid[i].Id == id)
                    {
                        return $"{listid[i].ToString()}";
                    }
                }
            }
            return $"not exist";
        }
    }
}
