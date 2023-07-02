using FastFood_Web.Service.Dtos.AccountDto;
using FastFood_Web.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountSevrice _accountSevrice;

        public AccountController(IAccountSevrice accountSevrice)
        {
            _accountSevrice = accountSevrice;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromForm] AccountLoginDto accountLoginDto)
        {
            return Ok(await _accountSevrice.LoginAsync(accountLoginDto));
        }


        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsynv([FromForm] AccountRegisterDto accountRegisterDto)
        {
            return Ok(await _accountSevrice.RegisterAsync(accountRegisterDto));
        }

        [HttpPost("send-to-Email")]
        public async Task<IActionResult> SendToEmail([FromForm] SendToEmailDto sendToEmail)
        {
            await _accountSevrice.SendCodeAsync(sendToEmail);
            return Ok();
        }

        //[HttpPatch("email-Verify")]
        //public async Task<IActionResult> UpdatePassword([FromForm] EmailVerifyDto updateDto)
        //{
        //    return Ok(await _accountSevrice.VerifyResetPasswordAsync(updateDto));
        //}

        //[HttpPost("reset-Password")]
        //public async Task<IActionResult> VerifyEmailAsync([FromForm] ResetPasswordDto userReset)
        //{
        //    return Ok(await _accountSevrice.UpdatePasswordAsync(userReset));
        //}


    }
}
