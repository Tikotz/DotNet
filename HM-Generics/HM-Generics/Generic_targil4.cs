using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Generics
{
    class CreateInstance<T> where T : new()
    {
        public T Instance {  get; set; }

        public CreateInstance()
        {
            Instance = new T();
        }
    }
    public class Person
    {
        public int Id { get; set; }
    }
    
}
