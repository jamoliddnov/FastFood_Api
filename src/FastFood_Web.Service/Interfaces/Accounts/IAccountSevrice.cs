using FastFood_Web.Service.Dto.AccountDto;

namespace FastFood_Web.Service.Interfaces.Accounts
{
    public interface IAccountSevrice
    {
        public Task<bool> RegisterAsync(AccountRegisterDto accountCreate);
        public Task<bool> UpdateAsync(string id, AccountUpdateDto accountUpdateDto);
    }
}
