using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Common.Security;
using FastFood_Web.Service.Dtos.AccountDto;
using FastFood_Web.Service.Helpers;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.ViewModels.Helpers;
using Microsoft.Extensions.Caching.Memory;
using System.Net;

#pragma warning disable

namespace FastFood_Web.Service.Services
{
    public class AccountService : IAccountSevrice
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthManager _authManager;
        private readonly IMemoryCache _memoryCache;
        private readonly IEmailService _emailService;

        public AccountService(IUnitOfWork unitOfWork, IAuthManager authManager, IMemoryCache memoryCache, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _authManager = authManager;
            _memoryCache = memoryCache;
            _emailService = emailService;
        }

        public async Task<string> LoginAsync(AccountLoginDto accountLogin)
        {
            var emailResult = await _unitOfWork.Customers.FirstOrDefaultAsync(x => x.Email == accountLogin.Email);
            if (emailResult is null)
            {
                throw new StatusCodeException(HttpStatusCode.NotFound, "User not found, Email is incorrect");
            }

            var userResult = await _unitOfWork.Users.FirstOrDefaultAsync(x => x.Id == emailResult.UserId);

            var userPassword = PassowrdHasher.Verify(accountLogin.Password, userResult.Salt, userResult.PasswordHash);

            if (userPassword)
            {
                return _authManager.GenerateToken(emailResult);
            }
            else
            {
                throw new StatusCodeException(HttpStatusCode.BadRequest, "Password is wrong!");
            }
        }

        public async Task<bool> RegisterAsync(AccountRegisterDto accountCreate)
        {
            var emailResult = await _unitOfWork.Customers.FirstOrDefaultAsync(x => x.Email == accountCreate.Email);
            if (emailResult is not null)
            {
                throw new StatusCodeException(HttpStatusCode.Conflict, "Email alredy exist");
            }

            var phoneNumber = await _unitOfWork.Users.FirstOrDefaultAsync(x => x.PhoneNumber == accountCreate.PhoneNumber);
            if (phoneNumber is not null)
            {
                throw new StatusCodeException(HttpStatusCode.Conflict, "Phone number alredy exist");
            }

            var passwordResult = PassowrdHasher.Hash(accountCreate.Password);

            var user = (User)accountCreate;
            user.CreateAt = TimeHelpers.GetCurrentServerTime();
            user.Salt = passwordResult.Salt;
            user.PasswordHash = passwordResult.PasswordHash;

            _unitOfWork.Users.Add(user);

            var customer = (Customer)accountCreate;
            customer.UserId = user.Id;
            _unitOfWork.Customers.Add(customer);

            var result = await _unitOfWork.SaveChangeAsync();
            return result > 0;
        }



        public async Task SendCodeAsync(SendToEmailDto sendToEmail)
        {
            int code = new Random().Next(100000, 999999);

            _memoryCache.Set(sendToEmail.Email, code, TimeSpan.FromMinutes(10));

            var message = new EmailMessage()
            {
                To = sendToEmail.Email,
                Subject = "Verification code",
                Body = code.ToString()
            };

            await _emailService.SendAsync(message);
        }


    }
}
