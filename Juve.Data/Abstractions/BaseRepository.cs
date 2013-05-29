using System;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Juve.Model;

namespace Juve.Data.Abstractions
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity: BaseEntity
    {
        protected readonly DbContext DbContext;
        public DbSet<TEntity> DbSet { get; set; }

        protected BaseRepository(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");

            DbContext = dbContext;
            DbSet = DbContext.Set<TEntity>();
        }

        public TEntity Single(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.SingleOrDefault(where);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void AddItem(TEntity entity)
        {
            DbSet.Add(entity);
            DbContext.SaveChanges();
        }

        public void DeleteItem(TEntity entity)
        {
            DbSet.Remove(entity);
            DbContext.SaveChanges();
        }

        public void UpdateItem(TEntity entity)
        {
            if (entity.Id == 0)
                DbSet.Add(entity);
            else
            {
                DbSet.Attach(entity);

                var adapter = DbContext as IObjectContextAdapter;
                var manager = adapter.ObjectContext.ObjectStateManager;
                manager.ChangeObjectState(entity, System.Data.EntityState.Modified);
            }

            DbContext.SaveChanges();
        }
    }
}
