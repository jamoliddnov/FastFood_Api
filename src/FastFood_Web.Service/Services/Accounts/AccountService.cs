﻿using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Dto.AccountDto;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Accounts;
using FastFood_Web.Service.Interfaces.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Net;

#pragma warning disable

namespace FastFood_Web.Service.Services.Accounts
{
    public class AccountService : IAccountSevrice
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthManager _authManager;
        private readonly IMemoryCache _memoryCache;
        private readonly IEmailService _emailService;
        private readonly IIdentityService _identityService;
        private readonly ICustomerService _customerService;
        private readonly IUserService _userService;

        public AccountService(IUnitOfWork unitOfWork, IAuthManager authManager, IMemoryCache memoryCache,
            IEmailService emailService, IIdentityService identityService, ICustomerService customerService, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _authManager = authManager;
            _memoryCache = memoryCache;
            _emailService = emailService;
            _identityService = identityService;
            _customerService = customerService;
            _userService = userService;
        }

        public async Task<bool> RegisterAsync(AccountRegisterDto accountCreate)
        {
            var phoneNumber = await _unitOfWork.Users.FirstOrDefaultAsync(x => x.PhoneNumber == accountCreate.PhoneNumber);
            if (phoneNumber is not null)
            {
                throw new StatusCodeException(HttpStatusCode.Conflict, "Phone number already exist");
            }

            var user = (User)accountCreate;

            user.Salt = "";
            user.PasswordHash = "";

            await _userService.CreateAsync(user);

            Customer customer = new Customer();
            customer.UserId = user.Id;
            var resultCustomer = await _customerService.CreateAsync(customer);

            var result = await _unitOfWork.SaveChangeAsync();
            return result > 0;
        }

        public async Task<bool> UpdateAsync(string id, AccountUpdateDto accountUpdateDto)
        {
            try
            {
                var resultCustomer = await _unitOfWork.Users.FirstOrDefaultAsync(x => x.Id == id);
                _unitOfWork.Entry(resultCustomer).State = EntityState.Detached;

                if (resultCustomer == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "User not found!");
                }

                if (accountUpdateDto.FullName != null)
                {
                    resultCustomer.FullName = accountUpdateDto.FullName;
                }

                _unitOfWork.Users.Update(resultCustomer, id);

                var result = await _unitOfWork.SaveChangeAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
