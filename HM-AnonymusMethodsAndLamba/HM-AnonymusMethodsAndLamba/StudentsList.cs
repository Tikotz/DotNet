using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_AnonymusMethodsAndLamba
{
    public class StudentManage
    {
        public static List<StudentList> StudentsList { get; set; } = new List<StudentList>();

        public StudentList Add(StudentList student)
        {
            if (student == null)
            {
                StudentsList.Add(student);
            }
            foreach (var item in StudentsList)
            {
                return item;
            }
            return null;
        }
        public StudentList Remove(StudentList student)
        {
            StudentsList.Remove(student);
            foreach (var item in StudentsList)
            {
                return item;
            }
            return null;
        }

        public static List<StudentList> Filter(filterDelegate filter)
        {
            List<StudentList> filterstudents = new List<StudentList>();
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (filter(StudentsList[i]))
                {
                    filterstudents.Add(StudentsList[i]);
                }
            }
            return filterstudents;
        }

        public static bool Contains(filterDelegate filter)
        {
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (filter(StudentsList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static int Sum(Filtersums filter)
        {
            int sum = 0;
            foreach (var student in StudentsList)
            {
                sum += filter(student);
            }
            return sum;

        }
        public static double Average(FilterAverage filter)
        {
            int count = 0;
            double sum = 0;
            foreach (var student in StudentsList)
            {
                sum += filter(student);
                count++;
            }
            return sum / count;
        }
    }
}
}
