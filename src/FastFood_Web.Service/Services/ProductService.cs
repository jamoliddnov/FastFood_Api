using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Dto.ProductDto;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.Services.Common.Utils;
using FastFood_Web.Service.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace FastFood_Web.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly IPaginatonService _paginatonService;


        public ProductService(IUnitOfWork unitOfWork, IFileService fileService, IPaginatonService paginatonService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
            _paginatonService = paginatonService;
        }
        public async Task<bool> CreateAsync(CreateProductDto productDto)
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

        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
                var resultDeleteProduct = await _unitOfWork.Products.FindByIdAsync(id);
                if (resultDeleteProduct is not null)
                {
                    _unitOfWork.Products.Delete(id);

                    var result = await _unitOfWork.SaveChangeAsync();

                    return result > 0;
                }
                throw new StatusCodeException(HttpStatusCode.NotFound, "Product not found!");

            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllAsync(PagenationParams @params)
        {
            try
            {

                var query = _unitOfWork.Products.GetAll();

                var queryParams = await _paginatonService.ToPageAsync(query, @params.PageNumber, @params.PageSize);

                if (queryParams.Count > 0)
                {
                    IList<ProductViewModel> productViewModels = new List<ProductViewModel>();

                    foreach (var item in queryParams)
                    {
                        ProductViewModel productViewModel = new ProductViewModel();
                        productViewModel.Id = item.Id;
                        productViewModel.Name = item.Name;
                        productViewModel.Price = item.Price;
                        productViewModel.FastFoodVolume = item.FastFoodVolume;
                        productViewModel.ImagePath = item.ImagePath;

                        productViewModels.Add(productViewModel);
                    }

                    return productViewModels;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Product> GetByIdAsync(string id)
        {
            try
            {
                var resultProduct = await _unitOfWork.Products.FindByIdAsync(id);

                if (resultProduct is not null)
                {
                    return resultProduct;
                }
                throw new StatusCodeException(HttpStatusCode.NotFound, "Product not found!");
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(string id, UpdateProductDto productDto)
        {
            try
            {
                var resultProduct = await _unitOfWork.Products.FindByIdAsync(id);

                if (resultProduct is not null)
                {
                    var result = _unitOfWork.Entry(resultProduct);
                    if (result.State == EntityState.Detached)
                    {
                        var product = (Product)productDto;

                        product.Id = id;
                        if (product.Name is null)
                        {
                            product.Name = resultProduct.Name;
                        }
                        if (product.Price == null)
                        {
                            product.Price = resultProduct.Price;
                        }
                        if (product.CategoryId is null)
                        {
                            product.CategoryId = resultProduct.CategoryId;
                        }
                        if (product.FastFoodVolume == null)
                        {
                            product.FastFoodVolume = resultProduct.FastFoodVolume;
                        }
                        if (product.ImagePath == null)
                        {
                            product.ImagePath = resultProduct.ImagePath;
                        }
                        else
                        {
                            product.ImagePath = await _fileService.SaveImageAsync(productDto.Image);

                        }

                        _unitOfWork.Products.Update(product, id);

                        var results = await _unitOfWork.SaveChangeAsync();

                        return results > 0;
                    }
                }
                throw new StatusCodeException(HttpStatusCode.NotFound, "Product not found!");
            }
            catch
            {
                return false;
            }
        }
    }
}
