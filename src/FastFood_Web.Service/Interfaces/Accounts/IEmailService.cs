using FastFood_Web.Service.ViewModels.Helpers;

namespace FastFood_Web.Service.Interfaces.Accounts
{
    public interface IEmailService
    {
        public Task<bool> SendAsync(EmailMessage emailMessage);
    }
}
