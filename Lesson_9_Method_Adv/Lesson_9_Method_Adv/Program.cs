using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Method_Adv
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //MyInt myInt = new MyInt
            //{
            //    x = 10
            //};

            //Console.WriteLine(x);
            //Console.WriteLine(myInt.ToString());

            #region override and virtual
            //Student s = new Student();
            //person ss = new Student();
            //s.GetYourName();
            //ss.GetYourName();

            //virtual and override
            //Student fullStudent = new Student();//הצבה וזיכרון של הבן
            //Person ps = new Student();//הצבה של האבא וזיכרון של הבן
            //fullStudent.virtualAndOverride();
            //ps.virtualAndOverride();

            //only override
            //fullStudent.onlyVirtual();//מימוש של הבן עם הערה
            //ps.onlyVirtual();//מימוש של האבא
            #endregion

            #region this and base
            //Person person = new Person();
            //Student s = new Student();
            //Console.WriteLine(person);
            //Console.WriteLine(s.ToString());
            #endregion

            #region ref
            //value type
            //int xx = 10;
            //increceNumber(ref xx);
            //Console.WriteLine(xx);


            //refference type

            int howManyRecycled = 0;
            int maxRecycled = 5;
            bottle[] arr = new bottle[10];

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine("Enter type of bottle");
                bottle b = new bottle(Console.ReadLine());
                for (int i = 0; i < 1000; i++)
                {
                    b.Recycled(ref howManyRecycled, ref maxRecycled);
                }
                arr[j] = b;
                howManyRecycled = 0;
            }


            #endregion
        }
        static void increceNumber(ref int xx)
        {
            xx++;
            Console.WriteLine(xx);
        }



        
    }

    


    class Person
    {
        public string name = "dan";
        public int age = 23;


        public virtual void virtualAndOverride()
        {
            Console.WriteLine(name);
        }

        public virtual void onlyVirtual()
        {
            Console.WriteLine(name);
        }

        public override string ToString()
        {
            return $"name: {name}. age:{age}";
        }
    }

    class Student : Person
    {
        public int grade;

        public override void virtualAndOverride()
        {
            Console.WriteLine(name + " " + age);
        }

        public  void onlyVirtual()
        {
            Console.WriteLine(name + " " + age);
        }

        public override string ToString()
        {
            return base.ToString() + $" grade: {grade}";
        }
    }

    class MyInt
    {
        public int x;

        public override string ToString()
        {
            return x.ToString();
        }
    }
}