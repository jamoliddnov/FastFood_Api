using FastFood_Web.Service.Dtos.AccountDto;

namespace FastFood_Web.Service.Interfaces
{
    public interface IAccountSevrice
    {
        public Task<string> LoginAsync(AccountLoginDto accountLogin);
        public Task<bool> RegisterAsync(AccountRegisterDto accountCreate);
        public Task SendCodeAsync(SendToEmailDto sendToEmail);

    }
}
