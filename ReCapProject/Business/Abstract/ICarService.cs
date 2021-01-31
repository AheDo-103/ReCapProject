using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetCars(Func<Car, bool> filter);
        Car GetCarById(int carId);
        bool Add(Car car);
        bool Update(Car car);
        bool Delete(Car car);
        bool Delete(List<Car> cars);
    }
}