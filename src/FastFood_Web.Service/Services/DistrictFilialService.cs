using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dto.DistrictFilialDto;
using FastFood_Web.Service.Interfaces;

namespace FastFood_Web.Service.Services
{
    public class DistrictFilialService : IDistrictFilialService
    {
        public Task<bool> CreateAsync(DistrictFilialCreateDto districtFilialCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DistrictFilial>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(string id, DistrictFilialUpdateDto districtFilialUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
