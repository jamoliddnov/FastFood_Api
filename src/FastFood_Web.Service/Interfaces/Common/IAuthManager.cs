using FastFood_Web.Domain.Entities.Users;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IAuthManager
    {
        public string GenerateToken(User customer);
    }
}
