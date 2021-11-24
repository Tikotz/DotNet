// See https://aka.ms/new-console-template for more information


public delegate void VoidSimpleDelegate();
public delegate void MyAction<in T1>(T1 t1);
public delegate void MyAction<in T1,in T2>(T1 t1,T2 t2);
public delegate void MyAction<in T1,in T2,in T3>(T1 t1, T2 t2, T3 t3);


public delegate T1 MyFunction<out T1>();
public delegate T2 MyFunction<in T1, out T2>(T1 t1);
public delegate T3 MyFunction<in T1,in T2, out T3>(T1 t1, T2 t2);

public delegate bool MyPredicate<in T>(T t);

public class Program
{
    static VoidSimpleDelegate MyDelegate1 = delegate () { };
    static VoidSimpleDelegate Mydelegate = () => { Console.WriteLine("My First Lamba"); };

    static void Main()
    {
        VoidSimpleDelegate MyMethod = () => {  };
        MyMethod();

        //Add 2 numbers and subtract the third
        MyAction<int, int, int> myAction1 = (a, b, c) =>
          {
              Console.WriteLine(a + b - c);
          };
        myAction1(6, 1, 2);


        /*Get student name, grade and age
         * print his name and "very smart" if age < grade -20
         */
        MyAction<string, int, int> printSmart = (name, grade, age) =>
        {
            if (age < grade - 20)
            {
                Console.WriteLine("{0} very smart !", name);
            }
        };
        printSmart("Ellen", 100,25);



        //Student Creator function
        MyFunction<string, int, Student> studentCreatorFunction = (name, id) => new Student()
          {
            Name = name,Id = id,
          };
        var student1 = studentCreatorFunction("Ori",123);
        Console.WriteLine(student1.Name);

        MyFunction<int, int,int> Add = (a, b) => a + b;
        MyFunction<int, int, int> Sub = (a, b) => a - b;

        Add(10, 40);
        Sub(40,10);


        MyPredicate<Student> myPredicate = student => student.Name.Length > 5;

    }

    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}