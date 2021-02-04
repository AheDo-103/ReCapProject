using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICarService : IBaseBll<Car>
    {
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
    }
}