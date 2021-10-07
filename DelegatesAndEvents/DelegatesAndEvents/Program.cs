using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegatesAndEvents.Student;

namespace DelegatesAndEvents
{
    class Program
    {
        static int x = 1;

        public static void SayShalom()
        {
            Console.WriteLine("Shalom");
        }
        public static void SayShalom2(string name)
        {
            Console.WriteLine($"Shalom {name}");
        }
        public static void Print2()
        {
            Console.WriteLine("Another funqtion calld with same delegate");
        }
        public static void Welcome(string name)
        {
            Console.WriteLine($"Wellcome {name}");
        }

        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            calc.Add(1, 2);
            Calculation.Sub(1, 2);

            MyFirstDelegate myDelegate1 = new MyFirstDelegate(SayShalom);
            MyFirstDelegate myDelegate2 = new MyFirstDelegate(Print2);
            myDelegate1();
            myDelegate2();
            GreetDelegate myGreet = new GreetDelegate(SayShalom2);
            GreetDelegate myGreet2 = new GreetDelegate(Welcome);
            myGreet("ori");
            myGreet2("ori");
            /*************************************************/

            var student1 = new Student() { Id = 1, Name = "ori" };
            var student2 = new Student() { Id = 2, Name = "Avichi" };

            MyFirstDelegate mydelegat3 = new MyFirstDelegate(student1.Go);
            MyFirstDelegate mydelegat4 = new MyFirstDelegate(student2.Go);

            mydelegat3();
            mydelegat4();
            var myDelegate5 = new MyFirstDelegate(student1.Go);
            myDelegate5+= student2.Go;
            myDelegate5();

            Console.WriteLine("----------------------------------");

            CalcDelegate calcDelegate1 = new CalcDelegate(new Calculation().Add);
            calcDelegate1 += Calculation.Sub;

            calcDelegate1(10, 20);

            Console.WriteLine("--------------------------------");

            //GetStudentListDelegate getStudentList = new GetStudentListDelegate(new Student().Add);
            //getStudentList(new Student() { Id = 1, Name = "ori"});
        }
    }
}
