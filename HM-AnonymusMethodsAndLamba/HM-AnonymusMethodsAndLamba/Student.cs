using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_AnonymusMethodsAndLamba
{
    public delegate bool filterDelegate(StudentList students);
    public delegate int Filtersums(StudentList student);
    public delegate double FilterAverage(StudentList student);


    public class StudentList
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public int Cost { get; set; }
        public int Paid { get; set; }

        public StudentList(string id, string firstName, string lastName, int age, int grade, int cost, int paid)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grade = grade;
            Cost = cost;
            Paid = paid;
        }



        


        public delegate StudentList GetStudentListDelegate(StudentList student);
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

}
