using FastFood_Web.Service.Dto.AccountDto;

namespace FastFood_Web.Service.Interfaces.Accounts
{
    public interface IAccountSevrice
    {
        public Task<string> LoginAsync(AccountLoginDto accountLogin);
        public Task<bool> RegisterAsync(AccountRegisterDto accountCreate);
        //public Task SendCodeAsync(SendCodeToEmailDto sendToEmail);
        //public Task<bool> VerifyResetPasswordAsync(EmailVerifyDto resetPasswordDto);
        //public Task<bool> UpdatePasswordAsync(ResetPasswordDto updateDto);

    }
}
