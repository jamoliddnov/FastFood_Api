using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Services.Common.Utils;

namespace FastFood_Web.Service.Interfaces
{
    public interface ICategoryService
    {
        public Task<bool> CreateAsync(CategoryFastFood categoryFastFood);
        public Task<bool> UpdateAsync(string id, CategoryFastFood categoryFastFood);
        public Task<bool> DeleteAsync(string id);
        public Task<IEnumerable<CategoryFastFood>> GetAllAsync(PagenationParams @params);   

       // public Task<CategoryFastFood> GetByIdAsync(string id);
       
   
    }
}
