using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Interfaces
{
    public interface IUserRepositorie : IGenericRepositorie<User>
    {
        public Task<User>? LastOrDefaultAsync(Expression<Func<User, bool>> expression);
    }
}
