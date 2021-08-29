using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_list_Compares
{
    class Students : IComparable<Students>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Students(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        
        public int CompareTo(Students? other)
        {
            if (other.LastName == LastName)
            {
                if (other.FirstName == FirstName)
                {
                    return Grade.CompareTo(other.Grade) * -1;
                }
                return FirstName.CompareTo(other.FirstName);
            }
            return LastName.CompareTo(other.LastName);
            
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} Grade: {Grade}";
        }
    }
    class TempurtureChack : IComparable<TempurtureChack>
    {
        public string City { get; set; }
        public string Date { get; set; }
        public int Temp { get; set; }
        public int Humidity { get; set; }

        public TempurtureChack(string city, string date, int temp, int humidity)
        {
            City = city;
            Date = date;
            Temp = temp;
            Humidity = humidity;
        }

        public int CompareTo(TempurtureChack? other)
        {
            if (City == other.City)
            {
                if (Temp == other.Temp)
                {
                    return Humidity.CompareTo(other.Humidity) * -1;
                }
                return Temp.CompareTo(other.Temp) * -1;
            }
            return City.CompareTo(other.City);
        }
        public override string ToString()
        {
            return $"{City} {Date} {Temp} {Humidity}";
        }
    }







    static class Program
    {
        static List<Students> list = new List<Students>();



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            list.Add(new Students("ori", "tikozki", 69));
            list.Add(new Students("adi", "cohen", 59));



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
