using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Events2
{
    //Declaration
    public delegate void SimpleDelegate()
;
    class Program
    {
        static void Print()
        {
            Console.WriteLine("Event was raized and I am the called method\n \n Number was entered");
        }
        static void NameIsTOOLong()
        {
            Console.WriteLine("Event was raized and I am the called method\n \n Name was too long");
        }
        static void NameisOK()
        {
            Console.WriteLine("Event was raized and I am the called method\n \n Name was OK");
        }


        #region 2
        public static void Lucky()
        {
            Console.WriteLine("WEEE, You'r Lucky");
        }
        public static void UnLucky()
        {
            Console.WriteLine("BOOOOZZ, You'r NOT Lucky\n Try Again");
        }
        #endregion
        public static void Luckystudent()
        {
            Console.WriteLine("You get 5% discount you Lucky Bustered");
        }

        #region 4
        public static void BallTouch()
        {
            Console.WriteLine("Outch!! i hit somthing !");
        }

        #endregion

        static void Main(string[] args)
        {

            #region 0
            NumbersWasEntered = Print;

            //Console.WriteLine("Enter string: ");
            //var str = Console.ReadLine();

            //foreach (var ch in str)  
            //{
            //    if (ch >= '0' && ch <= '9')
            //    {
            //        //Raize NumberWasEntered Event.
            //        if (NumbersWasEntered != null)
            //        {
            //            NumbersWasEntered(); //Invocation
            //        }
            //    }
            //}
            #endregion
            #region 1
            //TooLongName = NameIsTOOLong;
            //NameIsFINE = NameisOK;
            //StudentEvent student = new StudentEvent("oritikozki");
            //StudentEvent student2 = new StudentEvent("orii");


            //if (student.Name.Length >= 9)
            //{
            //    TooLongName();
            //}
            //else
            //{
            //    NameIsFINE();
            //}

            #endregion
            #region 2
            //LuckyNumberClass HM2 = new LuckyNumberClass();
            //HM2.LuckyNumberWasEntered += Lucky;
            //HM2.Lucky();




            //Console.WriteLine("Enter number: ");
            //var number = int.Parse(Console.ReadLine());
            //while (number != 999)
            //{
            //    UnLucky();
            //    Console.WriteLine("Enter number: ");
            //    number = int.Parse(Console.ReadLine());
            //}
            //LuckyNumberWasEntered();
            #endregion


            #region 3
            //LuckyStudent = Luckystudent;
            //while (StudentListEvents.students.Count <= 15)
            //{
            //    Console.WriteLine("enter name: ");
            //    StudentListEvents.students.Add(new StudentEvent(Console.ReadLine()));
            //    if (StudentListEvents.students.Count %5 == 0 )
            //    {
            //        LuckyStudent();
            //    }
            //}
            #endregion

            #region 4

            //Console.CursorVisible = false;
            //Console.SetWindowSize(81, 26);
            //Shape Sqare = new Shape();

            //Sqare.GenarateShape(4);

            //Random random = new Random();

            //Shape ball = new Shape();
            //int XBall = random.Next(1, 79);
            //int YBall = random.Next(1, 24);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.SetCursorPosition(XBall, YBall);
            //Console.Write(Sqare.MyChar);
            //while (Sqare.AllPossitions[XBall, YBall] == false)
            //{
            //    Sqare.AllPossitions[XBall, YBall] = true;
            //    ball.BallMove(ref XBall, ref YBall);
            //}
            //Shape.Outch += BallTouch;
            //BallTouch();
            #endregion

            #region 5


            #endregion

            //Timer timer = new Timer();
            //timer.Interval = 3000;
            //timer.Elapsed += Timer_Elapsed;
        }


        public static event SimpleDelegate TooLongName;
        public static event SimpleDelegate NameIsFINE;
        //public static event SimpleDelegate LuckyNumberWasEntered;
        public static event SimpleDelegate LuckyStudent;

        public static event SimpleDelegate NumbersWasEntered;

    }
}
