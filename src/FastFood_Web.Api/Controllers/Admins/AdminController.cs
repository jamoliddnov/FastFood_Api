using FastFood_Web.Service.Dtos.AdminDto;
using FastFood_Web.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers.Admins
{
    [Route("api/admins")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(AdminRegisterDto adminRegister)
        {
            return Ok(await _adminService.RegisterAsync(adminRegister));
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(AdminLoginDto adminLogin)
        { 
            return Ok(await _adminService.LoginAsync(adminLogin));
        }
    }
}
