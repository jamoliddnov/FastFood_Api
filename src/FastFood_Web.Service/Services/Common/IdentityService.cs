using FastFood_Web.Service.Interfaces.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

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
                var res = _accessor.HttpContext!.User.FindFirst(ClaimTypes.NameIdentifier);
                return res is not null ? res.Value : null;
            }
        }

        public string Email
        {
            get
            {
                var res = _accessor.HttpContext!.User.FindFirst(ClaimTypes.Email);
                return res is not null ? res.Value : string.Empty;
            }
        }

        public string UserRole
        {
            get
            {
                var res = _accessor.HttpContext!.User.FindFirst(ClaimTypes.Role)?.Value;
                return res is not null ? res : string.Empty;

            }
        }
    }
}



