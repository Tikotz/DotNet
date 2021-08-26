using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGenerics
{
    class GenericSimple
    {
        //public T add(T num1, T num2)
        //{
        //    return default(T);
        //}
        public void targil3<T>(T a,T b,T c)
        {

        }
    }
    class MyChishuvaishen
    {
        public void Print<T>(T arg1)
        {

        }
        public void Swap<T>(T arg1, T arg2)
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
            Console.WriteLine($"arg1 is {arg1} arg2 is {arg2}");
        }
        public void SwapRef<T>(T arg1, T arg2) where T : struct
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            MyChishuvaishen myChishuvaishen= new MyChishuvaishen();
            myChishuvaishen.Print<int>(69);
            myChishuvaishen.Print<string>("Bloop");
            myChishuvaishen.Swap<int>(5, 8);
            myChishuvaishen.Swap<string>("hi","bye");
            myChishuvaishen.Swap<char>('a', 'b');
            //myChishuvaishen.SwapRef<string>("a","b");
            //MyClass<int> myclass = new MyClass<int>();
            MyClass<myEntity> myintentity = new MyClass<myEntity>();

            GenericSimple targil3 = new GenericSimple();
            targil3.targil3<int>(2, 4, 6);
            targil3.targil3<string>("ori", "is", "here");


        }
        
    }
}
