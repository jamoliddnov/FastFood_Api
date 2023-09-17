using FastFood_Web.Domain.Common;

namespace FastFood_Web.Service.Interfaces
{
    public interface ILocationService
    {
        public Task<string> CreateAsync(Location location);

    }
}
