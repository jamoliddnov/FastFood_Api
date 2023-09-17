using FastFood_Web.Service.Dto.DistrictDto;
using FastFood_Web.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers
{
    [Route("api/district")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromForm] DistrictCreateDto district)
        {
            return Ok(await _districtService.CreateAsync(district));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(string id, [FromForm] DistrictUpdateDto districtUpdateDto)
        {
            return Ok(await _districtService.UpdateAsync(id, districtUpdateDto));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            return Ok(await _districtService.DeleteAsync(id));
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _districtService.GetAllAsync());
        }


    }
}
