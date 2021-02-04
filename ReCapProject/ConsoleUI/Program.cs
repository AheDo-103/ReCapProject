using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            List<Car> cars = carManager.GetAll();
            cars.ForEach(x => Console.WriteLine(x.CarName));
            // Car car = new Car()
            // {
            //     BrandId = 2,
            //     ColorId = 1,
            //     CarName = "BMW 320i Sedan M Sport",
            //     DailyPrice = 14255,
            //     ModelYear = 2020,
            //     Description = null,
            // };
            // var result = carManager.Insert(car);
            // if (!result)
            //     Console.WriteLine("Ekleme işlemi iptal edildi. Araba ismi veya Günlük Ücret hatalı.");
            // else
            //     Console.WriteLine("\n-----------Ekleme işlemi başarılı.\n");
            // cars = carManager.GetAll();
            // cars.ForEach(x => Console.WriteLine(x.CarName));
            // Car car = carManager.Get(17);
            // car.DailyPrice = 13798;
            // carManager.Update(car);
            // Console.WriteLine("\n-----------Ekleme işlemi başarılı.\n");
            // carManager.GetAll().ForEach(x => Console.WriteLine(x.DailyPrice));
            
            
            Console.WriteLine("\n-----------Ekleme işlemi başarılı.\n");
            Car car = carManager.Get(19);
            carManager.Delete(car);
            carManager.GetAll().ForEach(x => Console.WriteLine(x.CarName));
        }
    }
}