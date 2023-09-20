using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Repositories.Common
{
    public class LocationRepositories : GenericRepositorie<Location>, ILocationRepositories
    {
        public LocationRepositories(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<Location>? LastOrDefaultAsync(Expression<Func<Location, bool>> expression)
        {
            try
            {
                var result = await _dbSet.OrderByDescending(x => x.Id).LastOrDefaultAsync(expression);

                if (result != null)
                {
                    return result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
