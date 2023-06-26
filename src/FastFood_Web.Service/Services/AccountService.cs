using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.Service.Dtos.AccountDto;
using FastFood_Web.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.Service.Services
{
    public class AccountService : IAccountSevrice
    {
        private readonly AppDbContext _appDbContext;

        public AccountService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<string> LoginAsync(AccountLoginDto accountLogin)
        {
            var emailResult = await _appDbContext.Customers.FirstOrDefaultAsync(x => x.Email == accountLogin.Email);
            if (emailResult is null)
            {
                return "";
            }
            return "";
        }

        public async Task<bool> RegisterAsync(AccountRegisterDto accountCreate)
        {
            throw new NotImplementedException();
        }
    }
}
