using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcions
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDateFourTimes();//יצירת פונקציה 

            //GetMyAge
            int age = GetMyAge();
            Console.WriteLine(age);

            //GetMyName
            string name = GetMyName();
            Console.WriteLine(name);

            //GetFullName
            string fullname = GetFullName("Ellen", "Kozlitin");//מחזירה למשתנה אחד
            Console.WriteLine(fullname);

            //PrintDetails
            PrintDetails(fullname, age);// PrintDetails("Ellen Kozlitin", 13); - same
        }

        public static void PrintDateFourTimes()//קריאה לפנוקציה
        {
            //הדפסה שמבצעת הפנוקציה
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
        }

        //לא מקבלת ערכים ומחזירה מספר
        public static int GetMyAge()
        {
            return 13;
        }

        //לא מקבלת ערכים ומחזירה טקסט
        public static string GetMyName()
        {
            return "Ellen";
        }

        //מקבלת 2 ארגומנטים ומחזירה טקסט
        public static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
        public static void PrintDetails(string shuki, int age)
        {
            Console.WriteLine(shuki + " " + age);
        }
    }
    
}
