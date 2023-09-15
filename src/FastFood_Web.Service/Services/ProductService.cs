using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dtos;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Common;

namespace FastFood_Web.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;


        public ProductService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
        }
        public async Task<bool> CreateAsync(ProductDto productDto)
        {
            try
            {
                var product = (Product)productDto;

                if (productDto.Image is not null)
                {
                    product.ImagePath = await _fileService.SaveImageAsync(productDto.Image);
                }

                _unitOfWork.Products.Add(product);
                var result = await _unitOfWork.SaveChangeAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
