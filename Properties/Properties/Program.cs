using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HM Properties
            //Quoatation Q1 = new Quoatation("ori", new DateTime(2021,12,07),2);
            //Q1.SumLines[0] = 1000;
            //Console.WriteLine(Q1.DocSum);
            //Q1.SumLines[1] = 500;
            //Console.WriteLine(Q1.DocSum);
            //Q1.ChangeMainDetails("AVICHI", new DateTime(2021, 11, 08));
            #endregion

            #region HM Interface
            SeaKing seaking = new SeaKing();
            dog dogo = new dog();
            fish nemo = new fish();
            AnimalIsHungry(seaking);
            #endregion
            Plane pl = new Plane();
            Crow cr = new Crow();
            Fly(pl);
            Fly(cr);

            #region ubstract


            #endregion
        }
        public static void AnimalIsHungry(IAnimal a)
        {
            if (a is IMakeSundable)
            {
                (a as IMakeSundable).MakeSoundBeforeEating();
            }
            else
            {
                a.Eat();
            }
            
        }
        public static void AnimalIsTierd(IAnimal a)
        {
            a.Sleep();
        }

        public static void Fly(IFlyable IFly)
        {
            IFly.fly();
        }
    }

    class Crow : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("i can fly");
        }


        public double GetAttitude(double attitude)
        {
            return attitude;
        }
    }
    class Plane : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("i can fly too");
        }


        public double GetAttitude(double attitude)
        {
            return attitude;
        }
    }

    class Quoatation
    {
        public string CustomerName { get; private set; }
        public double[] SumLines { get; set; }
        public double DocSum 
        { 
            get 
            {
                double docsum = 0;
                for (int i = 0; i < SumLines.Length; i++)
                {
                    if (SumLines[i] == 0)
                    {
                        return docsum;
                    }
                    else
                    {
                        docsum = SumLines[i];
                    }
                }
                return docsum;
            } 
        }
        public DateTime ValidUntil { get; private set; }

        public Quoatation(string customerName, DateTime validUntil, int NumOfLines)
        {
            CustomerName = customerName;
            SumLines = new double[NumOfLines];
            ValidUntil = validUntil;
        }

        public void ChangeMainDetails(string costumerName, DateTime validUntil)
        {
            CustomerName = costumerName;
            ValidUntil = validUntil;
        }
        
    }

    public abstract class Shape
    {
        public string Name { get; set; }
        public int Angles { get; set; }

        public string GetShapeName()
        {
            return Name;
        }

        public abstract void CalcArea();
    }
}
