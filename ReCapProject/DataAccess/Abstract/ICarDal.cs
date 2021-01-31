using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetCars();
        List<Car> GetCars(Func<Car, bool> filter);
        Car GetCarById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        void Delete(List<Car> cars);
    }
}