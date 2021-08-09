using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_And_Catch
{
    class Garage : IGarage
    {
        public Car[] Cars { get; set; }
        public string[] CarTyps { get; set; }
        //public Car[] CanFixCars { private get; set; }

        public Garage(string[] carTyps, int amountOfCars)
        {
            Cars = new Car[amountOfCars];
            CarTyps = carTyps;
        }

        //public Garage(Car[] cars)
        //{
        //    int _index = 0;
        //    for (int i = 0; i < cars.Length; i++)
        //    {
        //        if (cars[i].TotalLoss == false)
        //        {
        //            CanFixCars[_index] = cars[i];
        //            _index++;
        //        }
        //    }
        //}

        public void AddCar(Car car)
        {
            try
            {
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (car == Cars[i])
                    {
                        throw new CarAlreadyHereException();
                    }
                    else if (car.TotalLoss)
                    {
                        throw new WeDoNotFixTotalLostException();
                    }
                    else if (car.NeedRepair == false)
                    {
                        throw new RepairMismatchException();
                    }
                    for (int j = 0; j < CarTyps.Length; j++)
                    {
                        if (car.Brand == CarTyps[j])
                        {
                            break;
                        }
                        else if(car.Brand != CarTyps[j] && j == CarTyps.Length-1)
                        {
                            throw new WrongGarageException();
                        }
                    }
                }
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (Cars[i] == null) 
                    {
                        Cars[i] = car;
                        break;
                    }
                }
                Console.WriteLine("the car added succesfully");
            }
            catch(CarAlreadyHereException)
            {
                Console.WriteLine("car is alraedy here...");
            }
            catch(WeDoNotFixTotalLostException)
            {
                Console.WriteLine("this car is total lost go away !");
            }
            catch (WrongGarageException)
            {
                Console.WriteLine("we dont fix this car brand");
            }
            catch (RepairMismatchException)
            {
                Console.WriteLine("that car doesnt need repair");
            }
            
            catch (NullReferenceException)
            {
                Console.WriteLine("the car is null");
            }
        }

        public void FixCar(Car[] cars)
        {

            Console.WriteLine("the car is fixed");
            
        }

        public void TakeOutCar(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].NeedRepair == true)
                {
                    Console.WriteLine("the car is not fixed yet");
                }
            }
        }
    }
}
