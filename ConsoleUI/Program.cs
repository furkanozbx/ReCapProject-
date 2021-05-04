using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarGetAllTest();
            //CarGetByIdTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" || " + car.BrandName+" || "+car.ColorName);
            }
        }

        private static void CarGetByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(2);
            Console.WriteLine(result.Description);
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " -- " + car.Description);
            }
        }
    }
}
