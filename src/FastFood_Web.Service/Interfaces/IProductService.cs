using FastFood_Web.Service.Dtos;

namespace FastFood_Web.Service.Interfaces
{
    public interface IProductService
    {

        public Task<bool> CreateAsync(ProductDto productDto);

    }
}
