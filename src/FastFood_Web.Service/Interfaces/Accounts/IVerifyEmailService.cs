using FastFood_Web.Service.Dto.AccountDto;

namespace FastFood_Web.Service.Interfaces.Accounts
{
    public interface IVerifyEmailService
    {
        public Task<bool> SendCodeAsync(SendCodeToEmailDto sendCodeToEmail);
        public Task<bool> VerifyPasswordAsync(ResetPasswordDto resetPasswordDto);
    }
}
