using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCars()
        {
            return _carDal.GetCars();
        }

        public List<Car> GetCars(Func<Car, bool> filter)
        {
            return _carDal.GetCars(filter);
        }

        public Car GetCarById(int carId)
        {
            return _carDal.GetCarById(carId);
        }

        public bool Add(Car car)
        {
            // Validation
            if (car.BrandId <= 0 || car.ColorId <= 0 || car.DailyPrice <= 0) return false;
            _carDal.Add(car);
            return true;
        }

        public bool Update(Car car)
        {
            // Validation
            if (car.BrandId <= 0 || car.ColorId <= 0 || car.DailyPrice <= 0) return false;
            _carDal.Update(car);
            return true;
        }

        public bool Delete(Car car)
        {
            if (car.CarId <= 0) return false;
            _carDal.Delete(car);
            return true;
        }

        public bool Delete(List<Car> cars)
        {
            foreach (var car in cars)
                if (car.CarId <= 0)
                    return false;
            _carDal.Delete(cars);
            return true;
        }
    }
}