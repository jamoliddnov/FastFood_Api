using FastFood_Web.Domain.Entities;

namespace FastFood_Web.Service.Interfaces
{
    public interface ICustomerService
    {
        public Task<bool> CreateAsync(Customer customer);
    }
}
