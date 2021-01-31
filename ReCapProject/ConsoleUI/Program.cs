using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        // CarManager instance;
        static CarManager carManager = new CarManager(new InMemoryCarDal());
        static void Main(string[] args)
        {
            // Arabaları listeleme;
            //carManager.GetCars().ForEach(x => Console.WriteLine($"{x.CarId}. Id'li {x.BrandId} Marka Idsine Sahip olan ürünün ColorIdsi {x.ColorId}'dir ve Model yılı {x.ModelYear}'dır. Ürünün günlük ücreti {x.DailyPrice}TL'dir.\nAçıklama: {x.Description}"));

            // Yeni araba ekleme;
            Car carForInsert = new Car() { CarId = 12, BrandId = 3, ColorId = 7, ModelYear = 2017, DailyPrice = 460, Description = "Orta seviye" };
            carManager.Add(carForInsert);
            Listele();

            // Id numarası 7 olan arabayı güncelleme;
            Car carForUpdate = carManager.GetCarById(7);
            carForUpdate.BrandId = 42;
            carForUpdate.ColorId = 54;
            carForUpdate.ModelYear = 2020;
            carForUpdate.DailyPrice = 750;
            carForUpdate.Description = "Yeey.";
            Listele();

            // Id numarası 8, 9, 10 ve 11 olan arabaları silme;
            carManager.Delete(carManager.GetCars(x => x.CarId >= 8 && x.CarId <= 11).ToList());
            Listele();
        }

        // Sürekli aynı kodu yazmamak için Listeleme fonksiyonu açtım
        static void Listele()
        {
            carManager.GetCars().ForEach(x => Console.WriteLine($"{x.CarId}. Id'li {x.BrandId} Marka Idsine Sahip olan ürünün ColorIdsi {x.ColorId}'dir ve Model yılı {x.ModelYear}'dır. Ürünün günlük ücreti {x.DailyPrice}TL'dir.\nAçıklama: {x.Description}"));
        }
    }
}
