
//Directory.CreateDirectory(@"C:\Users\ori\Documents\workspace\.net\DirectoryTest");
using Microsoft.Extensions.DependencyModel;
using System.IO;
using System.Text.Json;
using DirectoryAndFiles1;

#region question 1
var directorys = Directory.GetDirectories(@"C:\Users\ori\Documents\workspace\.net");
foreach (var item in directorys.Take(10))
{
    Console.WriteLine(item);
}

#endregion



Console.WriteLine("=====================================================================");




#region question 2
static void Question2(string direct)
{
    var dir = new DirectoryInfo(direct);
    var res = dir.GetFiles().OrderByDescending(f => f.Length).Take(3).ToList();
    foreach (var file in res)
    {
        Console.WriteLine(file.Name + "last update" + file.LastWriteTime);
    }
}
Question2(@"C:\Users\ori\Documents\workspace\.net");
#endregion


Console.WriteLine("=====================================================================");



#region question 3
Car.Cars.Add(new Car { Id = "1", Brand = "Bugati" });
Car.Cars.Add(new Car { Id = "2", Brand = "Ferari" });
Car.Cars.Add(new Car { Id = "3", Brand = "Maclaren" });
static void SaveBooksAsJSON()
{
    var jsonSTR = JsonSerializer.Serialize(Car.Cars);
    File.WriteAllText(@"C:\Users\ori\Documents\workspace\.net\Cars.json", jsonSTR);
}
SaveBooksAsJSON();
#endregion


#region question 4
static void SaveCarsAsFixedLaength()
{
    var s = "";
    foreach (var car in Car.Cars)
    {
        s += car.ToFixedLength() + Environment.NewLine;
    }
}
SaveCarsAsFixedLaength();

#endregion


#region question 5
static void SaveBooks()
{
    var s = "";
    foreach (var car in Car.Cars)
    {
        s += car.ToCSV() + Environment.NewLine;
    }
    File.WriteAllText(@"C:\Users\ori\Documents\workspace\.net\Cars.csv", s);
}
SaveBooks();

#endregion

#region question 6

static void ReadCSVFile()
{
    var listOfObjects = File.ReadAllLines(@"C:\Users\ori\Documents\workspace\.net\Cars.csv").ToList();
}
ReadCSVFile();
#endregion

#region 7
//Fixed Length יותר חסחוני
#endregion

#region 8
//הוא מגביל אותך באורכים
#endregion
#region 9
//קובץ בינארי יכול להכיל את כל התווים שיש לעומת קובץ טקסט רגיל 
#endregion














//using (var StreamWriter = new StreamWriter(@"C:\Users\ori\Documents\workspace\.net\a.csv"))
//{
//    for (int i = 1; i <= 1000; i++)
//    {
//        StreamWriter.WriteLine("Line hellow ori");
//    }
//}

//var StreamReader = new StreamReader(@"C:\Users\ori\Documents\workspace\.net\a.csv");
//using (StreamReader)
//{
//    string line = string.Empty;
//    while(line != null)
//    {
//        line = StreamReader.ReadLine();
//        Console.WriteLine(line);
//    }
//}


