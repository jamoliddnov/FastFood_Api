using FastFood_Web.Service.Dto.ProductDto;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Services.Common.Utils;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromForm] CreateProductDto productDto)
        {
            return Ok(await _productService.CreateAsync(productDto));
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateAsync(string id, [FromForm] UpdateProductDto productDto)
        {
            return Ok(await _productService.UpdateAsync(id, productDto));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            return Ok(await _productService.DeleteAsync(id));
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        {
            return Ok(await _productService.GetAllAsync(new PagenationParams(page)));
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] string id)
        {
            return Ok(await _productService.GetByIdAsync(id));
        }
    }
}


