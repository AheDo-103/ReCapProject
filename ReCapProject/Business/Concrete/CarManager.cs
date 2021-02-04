using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll().ToList();
        }
        
        public List<Car> GetAll(Expression<Func<Car, bool>> filter)
        {
            return _carDal.GetAll(filter).ToList();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _carDal.GetAll(x => x.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAll(x => x.ColorId == colorId).ToList();
        }

        public Car Get(int id)
        {
            return _carDal.Get(x => x.CarId == id);
        }

        public bool Insert(Car entity)
        {
            if (entity.CarName.Length <= 2 || entity.DailyPrice < 0)
                return false;
            _carDal.Add(entity);
            return true;
        }

        public bool Update(Car entity)
        {
            if (entity.CarName.Length <= 2 || entity.DailyPrice < 0)
                return false;
            _carDal.Update(entity);
            return true;
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }
    }
}