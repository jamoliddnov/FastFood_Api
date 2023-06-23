using FastFood_Web.Domain.Common;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IGenericRepositorie<T> : IRepositore<T> where T : Base
    {
        public IQueryable<T> GetAll();
        public IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
