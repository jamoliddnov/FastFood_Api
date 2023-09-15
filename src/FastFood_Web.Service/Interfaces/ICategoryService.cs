using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Services.Common.Utils;

namespace FastFood_Web.Service.Interfaces
{
    public interface ICategoryService
    {
        public Task<bool> CreateAsync(Category categoryFastFood);
        public Task<bool> UpdateAsync(string id, Category categoryFastFood);
        public Task<bool> DeleteAsync(string id);
        public Task<IEnumerable<Category>> GetAllAsync(PagenationParams @params);
        public Task<Category> GetByIdAsync(string id);
    }
}
