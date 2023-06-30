using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

#pragma warning disable

namespace FastFood_Web.DataAccess.Repositories.Common
{
    public class BaseRepositorie<T> : IRepositore<T> where T : Base
    {
        protected AppDbContext context;
        protected DbSet<T> _dbSet;

        public BaseRepositorie(AppDbContext context)
        {
            this.context = context;
            _dbSet = context.Set<T>();
        }

        public virtual T Add(T entity)
        {
            try
            {
                var result = _dbSet.Add(entity);
                return result.Entity;
            }
            catch
            {
                return null;
            }
        }

        public virtual void Delete(string id)
        {
            try
            {
                var entity = _dbSet.Find(id);

                if (entity is not null)
                {
                    _dbSet.Remove(entity);
                }
            }
            catch
            {

            }
        }

        public virtual async Task<T?> FindByIdAsync(string id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch
            {
                return null;
            }
        }

        public virtual async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            try
            {
                return await _dbSet.FirstOrDefaultAsync(expression);
            }
            catch
            {
                return null;
            }
        }

        public virtual void TrackingDeteched(T entity)
        {
            try
            {
                context.Entry<T>(entity!).State = EntityState.Detached;
            }
            catch
            {

            }
        }

        public virtual void Update(T entity, string id)
        {
            try
            {
                entity.Id = id;
                _dbSet.Update(entity);
            }
            catch
            {

            }
        }
    }
}
