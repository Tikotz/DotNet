using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes
{
    abstract class VeihcleBase
    {
        public string Model { get; set; }
        public int NumOfWeels { get; set; }

        protected VeihcleBase(string model, int numOfWeels)
        {
            Model = model;
            NumOfWeels = numOfWeels;
        }

        abstract public void GetMaxNumOfPassangers();
        abstract public void GetMaxSpeed();
        public override string ToString()
        {
            return $"Model: {Model}, Number Of Weels: {NumOfWeels}";
        }
    }

    class Car : VeihcleBase
    {
        

        public Car(string model,int numberOfWeels ,int numberOfDoors): base(model, numberOfWeels)
        {
            Model = model;
            NumberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors { get; set; }
        public override void GetMaxNumOfPassangers()
        {
            Console.WriteLine("5 passangers");
        }

        public override void GetMaxSpeed()
        {
            Console.WriteLine("360 top speed");
        }

        public override string ToString()
        {
            return base.ToString() + $" Number of doors: {NumberOfDoors}";
        }
    }

    class MotorCycle : VeihcleBase
    {
        public MotorCycle(int numberOfHandBrakes, string model, int numberOfWeels): base(model, numberOfWeels)
        {
            NumberOfHandBrakes = numberOfHandBrakes;
        }

        public int NumberOfHandBrakes { get; set; }
        public override void GetMaxNumOfPassangers()
        {
            Console.WriteLine("2 passangers"); ;
        }

        public override void GetMaxSpeed()
        {
            Console.WriteLine("320 top speed"); ;
        }
        public override string ToString()
        {
            return base.ToString() + $" Number of Hand Brakes: {NumberOfHandBrakes}";
        }
    }

    class Carrier
    {
        public VeihcleBase[] Veihcles { get; set; }

        public Carrier(VeihcleBase[] veihcles)
        {
            Veihcles = veihcles;
        }
        public override string ToString()
        {
            string start = "";
            foreach (var i in Veihcles)
            {
                start += i + "\n";
            }
            return start;
        }
    }
}
