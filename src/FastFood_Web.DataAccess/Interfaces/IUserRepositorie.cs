using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities.Users;

namespace FastFood_Web.DataAccess.Interfaces
{
    public interface IUserRepositorie : IGenericRepositorie<User>
    {
        public Task<User?> GetByEmailAsync(string email);
    }
}
