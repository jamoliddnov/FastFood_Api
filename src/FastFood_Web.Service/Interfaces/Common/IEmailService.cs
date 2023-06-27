using FastFood_Web.Service.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IEmailService
    {
        public Task<bool> SendAsync(EmailMessage emailMessage);
    }
}
