using FastFood_Web.Domain.Common;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IRepositore<T> where T : Base
    {
        public Task<T?> FindByIdAsync(string id);
        public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        public T Add(T entity);
        public void Update(T entity, string id);
        public void Delete(string id);
        public void TrackingDeteched(T entity);
    }
}
