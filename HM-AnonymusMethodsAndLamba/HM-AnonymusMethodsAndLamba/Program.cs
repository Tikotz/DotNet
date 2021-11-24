// See https://aka.ms/new-console-template for more information

using HM_AnonymusMethodsAndLamba;

public class Program
{
    delegate void Greet(string name);
    delegate void Math(int n1, int n2);


    public static void Main()
    {
        #region 1
        Delegate HM1 = delegate () { Console.WriteLine("Shalom"); };
        Greet Lamba1 = name => { Console.WriteLine("shalom"); };
        #endregion
        #region 2
        Delegate HM2 = delegate (string name) { Console.WriteLine("Shalom {0}", name); };
        Greet Lamba2 = name => { Console.WriteLine("shalom {0}", name); };
        Delegate HM2_1 = delegate (string name) { Console.WriteLine("Welcome {0}", name); };
        Greet Lamba2_1 = name => { Console.WriteLine("Welcome {0}", name); };
        #endregion
        #region 4
        Math Add = delegate (int n1, int n2) { Console.WriteLine($"{n1} + {n2} = {n1 + n2}"); };
        Add(3, 2);
        Math Sub = delegate (int n1, int n2) { Console.WriteLine($"{n2} - {n1} = {n2 - n1}"); };
        Sub(3, 2);
        Math AddLamba = (n1, n2) => { Console.WriteLine(n1 + n2); };
        AddLamba(3, 2);
        Math SubLamba = (n1, n2) => { Console.WriteLine(n2 - n1); };
        SubLamba(3, 2);
        #endregion
        #region 5
        StudentManage.StudentsList.Add(new StudentList("123","ori", "tiko", 23, 49,100,50));
        StudentManage.StudentsList.Add(new StudentList("234","ori2", "omar", 12, 90,200,90));
        filterDelegate filterStudents = delegate (StudentList student)
        {
            if (student.Age > 18)
            {
                return true;
            }
            return false;
        };
        StudentManage.Filter(filterStudents);

        filterDelegate filterStudentLamba = (StudentList student) => 
        {
            if (student.Age > 18)
            {
                return true;
            }
            return false;
        };
        StudentManage.Filter(filterStudentLamba);
        #endregion
        #region 6
        filterDelegate filtercontains = delegate (StudentList student)
        {
            if (student.FirstName.Length > 3)
            {
                return true;
            }
            return false;
        };
        StudentManage.Contains(filtercontains);

        filterDelegate filtercontainsLamba = (StudentList student) =>
        {
            if (student.FirstName.Length > 3)
            {
                return true;
            }
            return false;
        };
        StudentManage.Contains(filtercontainsLamba);
        #endregion

        #region 7
        filterDelegate filtercontainsGrade = delegate (StudentList student)
        {
            if (student.Grade < 50)
            {
                return true;
            }
            return false;
        };
        StudentManage.Contains(filtercontainsGrade);

        filterDelegate filtercontainsGradeLamba = (StudentList student) =>
        {
            if (student.Grade < 50)
            {
                return true;
            }
            return false;
        };
        StudentManage.Contains(filtercontainsGradeLamba);
        #endregion
        #region 8
        filterDelegate NameAndLastName = delegate (StudentList student)
        {
            for (int i = 0; i < StudentManage.StudentsList.Count; i++)
            {
                if (student.FirstName[0] == student.LastName[0])
                {
                    return true;
                }
            }
            return false;
        };
        StudentManage.Contains(NameAndLastName);

        filterDelegate NameAndLastNameLambda = (StudentList student) =>
        {
            for (int i = 0; i < StudentManage.StudentsList.Count; i++)
            {
                if (student.FirstName[0] == student.LastName[0])
                {
                    return true;
                }
            }
            return false;
        };
        StudentManage.Contains(NameAndLastNameLambda);
        #endregion

        #region 9
        Filtersums PaidSums = delegate (StudentList student)
        {
            return student.Paid;
        };
        StudentManage.Sum(PaidSums);

        Filtersums paidSumsLambda = (StudentList student) => 
        {
            return student.Paid;
        };


        Filtersums CostSums = delegate (StudentList student)
        {
            return student.Cost;
        };
        StudentManage.Sum(CostSums);

        Filtersums CostSumsLambda = (StudentList student) =>
        {
            return student.Cost;
        };
        StudentManage.Sum(CostSumsLambda);

        #endregion
        #region 10
        FilterAverage AgeAverage = delegate (StudentList student)
        {
            return student.Age;
        };
        StudentManage.Average(AgeAverage);

        FilterAverage AgeAverageLambda = (StudentList student) =>
        {
            return student.Age;
        };
        StudentManage.Average(AgeAverageLambda);

        FilterAverage GradeAverage = delegate (StudentList student)
        {
            return student.Grade;
        };
        StudentManage.Average(AgeAverage);

        FilterAverage GradeAverageLambda = (StudentList student) =>
        {
            return student.Grade;
        };
        StudentManage.Average(AgeAverageLambda);
        #endregion
    }
}
