using FastFood_Web.Service.Dtos.AccountDto;

namespace FastFood_Web.Service.Interfaces.Accounts
{
    public interface IVerifyPhoneNumberService
    {
        public Task<bool> SendCodeAsync(SendToPhoneNumberDto sendDto);
        public Task<string> VerifyPasswordNumberAsync(VerifyPhoneNumberDto verifyPhoneNumberDto);
    }
}



