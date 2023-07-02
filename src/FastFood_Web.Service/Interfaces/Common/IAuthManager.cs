using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Domain.Entities.Users;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IAuthManager
    {
        string GenerateAdminToken(Admin adminEmail);
        public string GenerateToken(User customer);
    }
}
