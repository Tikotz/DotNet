using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexsers2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }

    public class StudentManagment
    {
        Student[] Students = new Student[1000];
        public int Count {  get; set; }

        public Student GetStudentById(int id)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            return null;
        }

        internal void GetStudentById(string text)
        {
            throw new NotImplementedException();
        }

        public Student? GetStudentByName(string name)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Students[i].Name == name)
                {
                    return Students[i];
                }
            }
            return null;
        }

        public Student this[string name]
        {
            get
            {
                return GetStudentByName(name);
            }
        }
        public Student[] this[int grade]
        {
            get
            {
                int i = 0;
                Student[] BestStudents = new Student[1000];
                foreach (var student in Students)
                {
                    if (student.Grade > grade)
                    {
                        BestStudents[i++] = student;
                    }
                }
                return BestStudents;
            }
        }
    }
}
