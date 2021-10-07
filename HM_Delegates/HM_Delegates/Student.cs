using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Delegates
{
    public class Student
    {
        public Student(string id, string firstName, string lastName, int age, int grade, int cost, int paid)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grade = grade;
            Cost = cost;
            Paid = paid;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public int Cost { get; set; }
        public int Paid { get; set; }



        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
