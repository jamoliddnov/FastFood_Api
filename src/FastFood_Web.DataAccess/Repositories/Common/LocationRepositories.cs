using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.DataAccess.Repositories.Common
{
    public class LocationRepositories : GenericRepositorie<Location>, ILocationRepositories
    {
        public LocationRepositories(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<Location?> LastOrDefaultAsync(Location location)
        {
            try
            {
                var result = await _dbSet.OrderByDescending(x => x.Id).LastOrDefaultAsync(x => x.Latitude == location.Latitude && x.Longitude == location.Longitude);

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
