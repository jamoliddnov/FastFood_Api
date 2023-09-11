using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Entities.Empolyees;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IAuthManager
    {
        string GenerateAdminToken(Admin adminEmail);
        public string GenerateToken(User customer);
    }
}
