using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.ViewModels.Helpers;


namespace FastFood_Web.Service.Services.Common
{
    public class EmailService : IEmailService
    {
        public async Task<bool> SendAsync(EmailMessage emailMessage)
        {
           return false;
        }
    }
}
