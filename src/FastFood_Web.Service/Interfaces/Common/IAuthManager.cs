using FastFood_Web.Domain.Entities;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IAuthManager
    {
        public string GenerateToken(Customer customer);
    }
}
