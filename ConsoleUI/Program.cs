using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {

                    Console.WriteLine("Car Id : " + car.Id + "\n" + "Car Brand: " + car.BrandName +
                                       "\n" + "Car Color: " + car.ColorName + "\n" + "Daily Price: " + car.DailyPrice +
                                         "\n" + "Model Year: " + car.ModelYear + "\n" + "Description: " + car.Description + "\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}
