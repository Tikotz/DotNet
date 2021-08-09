using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_And_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tirgul
            //Client client1 = new Client();
            //client1.OrderDish();
            #endregion

            #region HM
            Garage gar = new Garage(new string[] { "ferari", "sunny", "Meri" },3);
            gar.AddCar(new Car("sunny", false, false));


            #endregion
        }
    }

    class Client
    {
        public void OrderDish()
        {
            try
            {
            Console.WriteLine("what dish do you want to order? " +
                "1 - falafel " +
                "2 - haburger" +
                "3 - pizza");
            int Dish = int.Parse(Console.ReadLine());
            Chef chef1 = new Chef();
            chef1.MakeDish(Dish);

            }
            catch(DishNotValidExeption)
            {
                Console.WriteLine("dish is not valid");
            }
        }
    }

    class Chef
    {
        public void MakeDish(int dish)
        {
            try
            {
                if (dish == 1)
                {
                    throw new PitaOutOfRangeExeption();
                }
                else if(dish < 1 || dish > 3)
                {
                    throw new DishNotValidExeption();
                    

                }
                else
                {
                    if (dish == 2)
                    {
                        Console.WriteLine("your Haburger has been ordered");
                    }
                    else if(dish == 3)
                    {
                        Console.WriteLine("your pizza has been ordered");
                    }
                    
                }
            }
            
            catch (PitaOutOfRangeExeption)
            {
                Console.WriteLine("pita is out of stock");
            }

        }
    }
}
