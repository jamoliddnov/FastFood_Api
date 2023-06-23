using FastFood_Web.Domain.Common;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IRepositore<T> where T : Base
    {
        public Task<T?> FindByIdAsync(Guid guid);
        public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        public T Add(T entity);
        public void Update(T entity, Guid guid);
        public void Delete(Guid guid);
        public void TrackingDeteched(T entity);
    }
}
