using System;
using System.Linq;
using System.Linq.Expressions;
using EfCoreWithWebApiSample.Entity;

namespace EfCoreWithWebApiSample.Repository.Infrastructure
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        Guid Save(T entity);
        T Get(Guid id);
        void Update(T entity);
        void Delete(Guid id);
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
