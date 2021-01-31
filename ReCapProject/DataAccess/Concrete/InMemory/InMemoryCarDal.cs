using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car() { CarId=1, BrandId=4, ColorId=9, ModelYear=2013, DailyPrice=231, Description="Orta seviye arzulayanların arabası."},
                new Car() { CarId=2, BrandId=4, ColorId=1, ModelYear=2015, DailyPrice=255, Description="Orta seviye arzulayanların arabası."},
                new Car() { CarId=3, BrandId=4, ColorId=1, ModelYear=2015, DailyPrice=250, Description="Orta seviye arzulayanların arabası."},
                new Car() { CarId=4, BrandId=9, ColorId=1, ModelYear=2015, DailyPrice=280, Description="Orta seviye arzulayanların arabası."},
                new Car() { CarId=5, BrandId=9, ColorId=9, ModelYear=2010, DailyPrice=150, Description="Ekonomik, güvenilir."},
                new Car() { CarId=6, BrandId=9, ColorId=5, ModelYear=2019, DailyPrice=335, Description="Hem lüx, hem ekonomik."},
                new Car() { CarId=7, BrandId=1, ColorId=5, ModelYear=2019, DailyPrice=350, Description="Hem lüx, hem ekonomik."},
                new Car() { CarId=8, BrandId=1, ColorId=4, ModelYear=2019, DailyPrice=350, Description="Hem lüx, hem ekonomik."},
                new Car() { CarId=9, BrandId=2, ColorId=2, ModelYear=2019, DailyPrice=350, Description="Hem lüx, hem ekonomik."},
                new Car() { CarId=10, BrandId=3, ColorId=3, ModelYear=2020, DailyPrice=450, Description="Lüxün daha makulu."},
                new Car() { CarId=11, BrandId=4, ColorId=3, ModelYear=2020, DailyPrice=500, Description="Lüxü arzulayanlar için."},
                // Veri girmeye üşendiğim için bu listeyi azorkai adlı arkadaşın github profilinden aldım =)
            };
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public List<Car> GetCars(Func<Car, bool> filter)
        {
            return _cars.Where(filter).ToList();
        }

        public Car GetCarById(int carId)
        {
            return _cars.Where(x => x.CarId == carId).FirstOrDefault();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.FirstOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Delete(List<Car> cars)
        {
            foreach (var car in cars)
                _cars.Remove(_cars.FirstOrDefault(x => x.CarId == car.CarId));
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.FirstOrDefault(x => x.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}