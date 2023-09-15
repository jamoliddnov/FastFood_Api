using FastFood_Web.Service.Dto.ProductDto;
using FastFood_Web.Service.Interfaces;
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
    }
}


