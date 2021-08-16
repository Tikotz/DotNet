using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexsers
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class StudentManagement
    {
        Student[] Students { get; set; } = new Student[100];
        public int Count { get; set; }
        public void Add(Student student)
        {
            Students[Count] = student;
            Count++;
        }
         
        public Student GetStudentByID(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                } 
            }
            return null;
        }
        public Student GetStudentByIndex(int index)
        {
            return Students[index];
        }
    }
}
