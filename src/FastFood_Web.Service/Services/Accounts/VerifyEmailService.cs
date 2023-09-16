using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Dto.AccountDto;
using FastFood_Web.Service.Interfaces.Accounts;
using Microsoft.Extensions.Caching.Memory;
using System.Net;

namespace FastFood_Web.Service.Services.Accounts
{
    public class VerifyEmailService : IVerifyEmailService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IEmailService _emailService;
        private readonly IUnitOfWork _unitOfWork;

        public VerifyEmailService(IMemoryCache memoryCache, IEmailService emailService, IUnitOfWork unitOfWork)
        {
            _memoryCache = memoryCache;
            _emailService = emailService;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> SendCodeAsync(SendCodeToEmailDto sendToEmail)
        {
            int code = new Random().Next(100000, 999999);

            _memoryCache.Set(sendToEmail.Email, code, TimeSpan.FromMinutes(10));

            var message = new EmailMessageDto()
            {
                To = sendToEmail.Email,
                Subject = "Verification code",
                Body = code.ToString()
            };

            var res = await _emailService.SendAsync(message);
            return res;
        }

        public async Task<bool> VerifyPasswordAsync(ResetPasswordDto resetPasswordDto)
        {
            var admin = await _unitOfWork.Admins.FirstOrDefaultAsync(x => x.Email == resetPasswordDto.Email);

            if (admin is null)
            {
                throw new StatusCodeException(HttpStatusCode.NotFound, "User not found!");
            }

            if (_memoryCache.TryGetValue(resetPasswordDto.Email, out int exception))
            {
                if (exception != resetPasswordDto.Code)
                {
                    throw new StatusCodeException(HttpStatusCode.BadRequest, "Code is wrong!");
                }
            }
            else
            {
                throw new StatusCodeException(HttpStatusCode.BadRequest, "Code is expired!");
            }
            return true;
        }
    }
}
