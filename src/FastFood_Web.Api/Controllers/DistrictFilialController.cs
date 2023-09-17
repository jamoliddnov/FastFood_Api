using FastFood_Web.Service.Dto.DistrictFilialDto;
using FastFood_Web.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers
{
    [Route("api/districtFilial")]
    [ApiController]
    public class DistrictFilialController : ControllerBase
    {
        private readonly IDistrictFilialService _districtFilialService;

        public DistrictFilialController(IDistrictFilialService districtFilialService)
        {
            _districtFilialService = districtFilialService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromForm] DistrictFilialCreateDto districtFilialCreateDto)
        {
            return Ok(await _districtFilialService.CreateAsync(districtFilialCreateDto));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(string id, [FromForm] DistrictFilialUpdateDto districtFilialUpdateDto)
        {
            return Ok(await _districtFilialService.UpdateAsync(id, districtFilialUpdateDto));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            return Ok(await _districtFilialService.DeleteAsync(id));
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _districtFilialService.GetAllAsync());
        }
    }
}
