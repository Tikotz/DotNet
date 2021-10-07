using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 10);
            }
            Console.WriteLine("**************************************");
            foreach (var item in new Sidra10To100())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************");
            foreach (var item in new Sidra(3))
            {
                Console.Write($"{item} ");
                Console.WriteLine("---");
            }

            List<Student> ListOfStudents = new List<Student>() { new Student("ori", 110), new Student("Avichi", 102), new Student("Efraim", 69) };
            foreach (var student_Grade in new StudentsThatAreGood(ListOfStudents))
            {
                Console.WriteLine(student_Grade);
            }
        }
    }
}
