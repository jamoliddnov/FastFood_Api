using FastFood_Web.Service.Dtos;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Services.Common.Utils;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromForm] CategoryDto category)
        {
            return Ok(await _categoryService.CreateAsync(category));
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateAsync(string id, [FromForm] CategoryDto categoryDto)
        {
            return Ok(await _categoryService.UpdateAsync(id, categoryDto));
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            return Ok(await _categoryService.DeleteAsync(id));
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync([FromQuery] int page = 1)
        {
            return Ok(await _categoryService.GetAllAsync(new PagenationParams (page)));
        }
    }
}
