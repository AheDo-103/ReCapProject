using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstract;

namespace Business.Abstract
{
    public interface IBaseBll<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> filter);
        T Get(int id);
        // T Get(Expression<Func<T, bool>> filter);
        bool Insert(T entity);
        bool Update(T entity);
        void Delete(T entity);
    }
}