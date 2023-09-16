using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Common.Security;
using FastFood_Web.Service.Dto.AccountDto;
using FastFood_Web.Service.Interfaces.Accounts;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System.Net;

namespace FastFood_Web.Service.Services.Accounts
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;


        public EmailService(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration.GetSection("EmailSettings");
            _unitOfWork = unitOfWork;

        }

        public async Task<bool> SendAsync(EmailMessageDto emailMessage)
        {
            try
            {
                var mail = new MimeMessage();
                mail.From.Add(MailboxAddress.Parse(_configuration["Email"]));
                mail.To.Add(MailboxAddress.Parse(emailMessage.To));
                mail.Subject = emailMessage.Subject;
                mail.Body = new TextPart(TextFormat.Html) { Text = emailMessage.Body };

                var smtp = new SmtpClient();
                await smtp.ConnectAsync(_configuration["Host"], int.Parse(_configuration["Port"]), MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_configuration["Email"], _configuration["Password"]);
                await smtp.SendAsync(mail);
                await smtp.DisconnectAsync(true);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> VerifyPasswordAsync(ResetPasswordDto emailVerifyDto)
        {
            var admin = await _unitOfWork.Admins.FirstOrDefaultAsync(x => x.Email == emailVerifyDto.Email);

            if (admin is null)
            {
                throw new StatusCodeException(HttpStatusCode.NotFound, "user not found!");
            }

            var adminPassword = PassowrdHasher.Hash(emailVerifyDto.Password);
            admin.PasswordHash = adminPassword.PasswordHash;
            admin.Salt = adminPassword.Salt;

            _unitOfWork.Admins.Update(admin, admin.Id);
            var result = await _unitOfWork.SaveChangeAsync();
            return result > 0;

        }
    }
}