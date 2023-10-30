using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace FastFood_Web.Service.Common
{
    public class HttpContextHelper
    {
        public static IHttpContextAccessor Accessor { get; set; }

        public static HttpContext HttpContext => Accessor?.HttpContext;
        public static long UserId => GetUserId();

        public static string UserRole => HttpContext?.User.FindFirst(ClaimTypes.Role)?.Value;
        private static long GetUserId()
        {
            long id;
            bool canParse = long.TryParse(HttpContext.User?.Claims.FirstOrDefault(p => p.Type == "Id")?.Value, out id);
            return canParse ? id : 0;
        }
    }
}
