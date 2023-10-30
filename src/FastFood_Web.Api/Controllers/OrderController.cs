using FastFood_Web.Domain.Enums;
using FastFood_Web.Service.Dto.OrderDto;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Services.Common.Utils;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromBody] OrderCreateDto orderCreateDto)
        {
            return Ok(await _orderService.CreateAsync(orderCreateDto));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(string id, [FromForm] OrderUpdateDto orderCreateDto)
        {
            return Ok(await _orderService.UpdateAsync(id, orderCreateDto));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            return Ok(await _orderService.DeleteAsync(id));
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync(ProcessStatus processStatus)
        {
            return Ok(await _orderService.GetAllAsync(new PagenationParams(1), processStatus));
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            return Ok(await _orderService.GetByIdAsync(id));
        }
    }
}
