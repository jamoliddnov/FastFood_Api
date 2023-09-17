using FastFood_Web.Domain.Common;

namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface ILocationRepositories : IGenericRepositorie<Location>
    {
        public Task<Location?> LastOrDefaultAsync(Location location);
    }
}
