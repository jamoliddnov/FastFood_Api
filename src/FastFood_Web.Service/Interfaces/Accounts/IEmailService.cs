using FastFood_Web.Service.Dto.AccountDto;

namespace FastFood_Web.Service.Interfaces.Accounts
{
    public interface IEmailService
    {
        public Task<bool> SendAsync(EmailMessageDto emailMessage);

        public Task<bool> VerifyPasswordAsync(ResetPasswordDto emailVerifyDto);
    }
}

