using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dto.DistrictDto;

namespace FastFood_Web.Service.Interfaces
{
    public interface IDistrictService
    {
        public Task<bool> CreateAsync(DistrictCreateDto districtCreateDto);
        public Task<bool> UpdateAsync(string id, DistrictUpdateDto districtUpdateDto);
        public Task<bool> DeleteAsync(string id);
        public Task<IEnumerable<District>> GetAllAsync();
    }
}
