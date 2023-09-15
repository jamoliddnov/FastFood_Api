using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dto.ProductDto;
using FastFood_Web.Service.Services.Common.Utils;
using FastFood_Web.Service.ViewModels;

namespace FastFood_Web.Service.Interfaces
{
    public interface IProductService
    {

        public Task<bool> CreateAsync(CreateProductDto productDto);
        public Task<bool> UpdateAsync(string id, UpdateProductDto productDto);
        public Task<bool> DeleteAsync(string id);
        public Task<IEnumerable<ProductViewModel>> GetAllAsync(PagenationParams @params);
        public Task<Product> GetByIdAsync(string id);

    }
}
