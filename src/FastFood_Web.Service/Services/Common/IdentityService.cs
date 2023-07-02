using FastFood_Web.Service.Interfaces.Common;
using Microsoft.AspNetCore.Http;

#pragma warning disable

namespace FastFood_Web.Service.Services.Common
{
    public class IdentityService : IIdentityService
    {
        private readonly IHttpContextAccessor _accessor;

        public IdentityService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string? Id
        {
            get
            {
                var res = _accessor.HttpContext!.User.FindFirst(Id);
                return res is not null ? res.Value : null;
            }
        }

        public string Email
        {
            get
            {
                var res = _accessor.HttpContext!.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress");
                return res is not null ? res.Value : string.Empty;
            }
        }
    }
}



