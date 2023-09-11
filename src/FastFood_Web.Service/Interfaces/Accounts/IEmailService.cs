using FastFood_Web.Service.Dtos.AccountDto;

namespace FastFood_Web.Service.Interfaces.Accounts
{
    public interface IEmailService
    {
        public Task<bool> SendAsync(EmailMessageDto emailMessage);

        public Task<bool> VerifyPasswordAsync(ResetPasswordDto emailVerifyDto);
        Task<object?> VerifyPasswordAsync(EmailVerifyDto emailVerifyDto);
    }
}

