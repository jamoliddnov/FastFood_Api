using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Interfaces;

namespace FastFood_Web.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(Customer customer)
        {
            try
            {
                _unitOfWork.Customers.Add(customer);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
