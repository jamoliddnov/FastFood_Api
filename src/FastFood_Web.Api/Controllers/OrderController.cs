﻿using FastFood_Web.Service.Dto.OrderDto;
using FastFood_Web.Service.Interfaces;
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

        [HttpPost("createOrderId")]
        public async Task<IActionResult> CreateAsync([FromBody] OrderCreateDto orderCreateDto)
        {


            return Ok(await _orderService.CreateAsync(orderCreateDto));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync()
        {
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            return Ok();
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok();
        }

        [HttpGet("getById")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            return Ok();
        }
    }
}
