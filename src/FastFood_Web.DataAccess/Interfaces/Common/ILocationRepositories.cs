using FastFood_Web.Domain.Common;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface ILocationRepositories : IGenericRepositorie<Location>
    {
        public Task<Location?> LastOrDefaultAsync(Expression<Func<Location, bool>> expression);
    }
}
