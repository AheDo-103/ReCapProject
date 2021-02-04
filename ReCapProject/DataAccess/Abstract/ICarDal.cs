using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        IEnumerable<Car> GetAllByColorId(Expression<Func<Car, bool>> filter);
        IEnumerable<Car> GetAllByBrandId(Expression<Func<Car, bool>> filter);
    }
}