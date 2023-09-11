using FastFood_Web.Service.Dtos.AccountDto;
using FastFood_Web.Service.Dtos.AdminDto;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Accounts;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers.Admins
{
    [Route("api/admins")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IEmailService _emailService;
        private readonly IVerifyEmailService _verifyEmailService;

        public AdminController(IAdminService adminService, IEmailService emailService, IVerifyEmailService verifyEmailService)
        {
            _adminService = adminService;
            _emailService = emailService;
            _verifyEmailService = verifyEmailService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromForm] AdminRegisterDto adminRegister)
        {
            return Ok(await _adminService.RegisterAsync(adminRegister));
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromForm] AdminLoginDto adminLogin)
        {
            return Ok(await _adminService.LoginAsync(adminLogin));
        }

        [HttpPost("send-to-email")]
        public async Task<IActionResult> SendtoEmail([FromForm] SendCodeToEmailDto codeToEmailDto)
        {
            return Ok(await _verifyEmailService.SendCodeAsync(codeToEmailDto));
        }

        [HttpPost("verify-email")]
        public async Task<IActionResult> VerifyEmail([FromForm] EmailVerifyDto emailVerifyDto)
        {
            return Ok(await _emailService.VerifyPasswordAsync(emailVerifyDto));
        }
    }
}
