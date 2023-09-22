using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using FastFood_Web.Service.Interfaces;

#pragma warning disable

namespace FastFood_Web.Service.Services
{
    public class LocationService : ILocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateAsync(Location location)
        {
            try
            {
                _unitOfWork.Locations.Add(location);

                return location.Id;
            }
            catch
            {
                return "";
            }
        }

        public async Task<Location>? GetByIdAsync(string id)
        {
            try
            {
                var result = await _unitOfWork.Locations.FirstOrDefaultAsync(x => x.Id == id);

                if (result == null)
                {
                    return null;
                }
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
