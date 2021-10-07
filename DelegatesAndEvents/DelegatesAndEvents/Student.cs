using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Student
    {
        public int Id {  get; set; }
        public string Name {  get; set; }

        public List<Student> Students {  get; set; }

        public Student Add(Student student)
        {
            if (student == null)
            {
                Students.Add(student);
            }
            foreach (var item in Students)
            {
                return item;
            }
            return null;
        }
        public Student Remove(Student student)
        {
            Students.Remove(student);
            foreach (var item in Students)
            {
                return item;
            }
            return null;
        }
        public void Go()
        {
            Console.WriteLine("my name is {0}",Name);
        }
        public void Filter()
        {

        }

        public delegate Student GetStudentListDelegate(Student student);
        public override string ToString()
        {
            return Name;
        }
    }
}
