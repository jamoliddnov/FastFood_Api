using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Repositories.Common
{
    public class BaseRepositorie<T> : IRepositore<T> where T : Base
    {
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<T?> FindByIdAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TrackingDeteched(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity, Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
