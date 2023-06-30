using FastFood_Web.Service.Dtos.AccountDto;
using FastFood_Web.Service.Interfaces;
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
        public async Task<IActionResult> LoginAsync([FromForm] AccountLoginDto accountLoginDto)
        {
            return Ok(await _accountSevrice.LoginAsync(accountLoginDto));
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsynv([FromForm] AccountRegisterDto accountRegisterDto)
        {
            return Ok(await _accountSevrice.RegisterAsync(accountRegisterDto));
        }

        [HttpPost("sendEmail")]
        public async Task<IActionResult> SendEmail([FromForm] SendToEmailDto sendToEmail)
        {
            await _accountSevrice.SendCodeAsync(sendToEmail);
            return Ok();
        }


    }
}
