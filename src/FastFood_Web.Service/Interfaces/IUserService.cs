using FastFood_Web.Domain.Entities;

namespace FastFood_Web.Service.Interfaces
{
    public interface IUserService
    {
        public Task<bool> CreateAsync(User user);
    }
}
