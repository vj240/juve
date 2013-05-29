using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Juve.Data.Abstractions
{
    public interface IBaseRepository<E> where E : class
    {
        DbSet<E> DbSet { get; set; }

        E Single(Expression<Func<E, bool>> where);
        IEnumerable<E> GetAll();
        void AddItem(E entity);
        void DeleteItem(E entity);
        void UpdateItem(E entity);
    }
}
