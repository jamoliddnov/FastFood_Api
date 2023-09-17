using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using FastFood_Web.Service.Interfaces;

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

                var result = await _unitOfWork.SaveChangeAsync();

                if (result > 0)
                {
                    var resultLocation = await _unitOfWork.Locations.LastOrDefaultAsync(location);
                    if (resultLocation != null)
                    {
                        return resultLocation.Id;
                    }
                }

                return "";
            }
            catch
            {
                return "";
            }
        }
    }
}
