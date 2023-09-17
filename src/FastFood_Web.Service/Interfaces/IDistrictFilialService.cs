using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dto.DistrictFilialDto;

namespace FastFood_Web.Service.Interfaces
{
    public interface IDistrictFilialService
    {
        public Task<bool> CreateAsync(DistrictFilialCreateDto districtFilialCreateDto);
        public Task<bool> UpdateAsync(string id, DistrictFilialUpdateDto districtFilialUpdateDto);
        public Task<bool> DeleteAsync(string id);
        public Task<IEnumerable<DistrictFilial>> GetAllAsync();

    }
}
