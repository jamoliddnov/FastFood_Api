using FastFood_Web.Service.Dto.AccountDto;
using FastFood_Web.Service.Interfaces.Accounts;
using Microsoft.AspNetCore.Mvc;

namespace FastFood_Web.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountSevrice _accountService;

        public AccountController(IAccountSevrice accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromForm] AccountRegisterDto accountRegisterDto)
        {
            return Ok(await _accountService.RegisterAsync(accountRegisterDto));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(string id, [FromForm] AccountUpdateDto accountUpdateDto)
        {
            return Ok(await _accountService.UpdateAsync(id, accountUpdateDto));
        }

    }
}
