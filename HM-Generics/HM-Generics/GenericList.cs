using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Generics
{
    class BasicProp
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Students : BasicProp
    {
        public override string ToString()
        {
            return $"student";
        }
    }

    
    class ReadOnlyCollection<T> where T : BasicProp
    {
        T[] list = new T[1000];
        public bool IsReadOnly { get; set; }
        public int count { get; set; } = 1;

        
        public void AddToList(T Data)
        {
            if (!IsReadOnly)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == null)
                    {
                        list[i] = Data;
                        list[i].Id = count;
                        list[i].Name = $"{Data.ToString()}{count}";
                        count++;
                        break;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("cant add because the list is readOnly");
            }
        }

        public void stopReadOnly()
        {
            if (IsReadOnly == true)
            {
                IsReadOnly = false;
            }
            else
            {
                IsReadOnly = true;
            }
        }
        public string FindById(int index)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Id == index)
                {
                    return list[i].Name;
                }
                
            }
            return null;
        }
    }
}
