using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Interfaces;

namespace FastFood_Web.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(User user)
        {
            try
            {
                _unitOfWork.Users.Add(user);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
