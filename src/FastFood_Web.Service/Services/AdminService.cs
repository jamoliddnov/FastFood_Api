using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Common.Security;
using FastFood_Web.Service.Dto.AdminDto;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Common;
using System.Net;
using System.Resources;


namespace FastFood_Web.Service.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthManager _authManager;
        private readonly IIdentityService _identityService;


        public AdminService(IUnitOfWork unitOfWork, IAuthManager authManager, IIdentityService identityService)
        {
            _unitOfWork = unitOfWork;
            _authManager = authManager;
            _identityService = identityService;

        }

        public async Task<string> LoginAsync(AdminLoginDto adminLoginDto)
        {

            //Properties.Settings.Default.Password = txtTex.Text;
            ResourceManager resourceManager = new ResourceManager("Email.Resources", typeof(string).Assembly);


            var r = Properties.Resources.Email;
            var adminEmail = await _unitOfWork.Admins.FirstOrDefaultAsync(x => x.Email == adminLoginDto.Email);

            if (adminEmail is null)
            {
                throw new StatusCodeException(HttpStatusCode.NotFound, "User not found, Email is incorrect");
            }

            var adminPassword = PassowrdHasher.Verify(adminLoginDto.Password, adminEmail.Salt, adminEmail.PasswordHash);

            if (adminPassword)
            {

                var res = _authManager.GenerateAdminToken(adminEmail);

                var role = _identityService.UserRole;

                return res;
            }
            else
            {
                throw new StatusCodeException(HttpStatusCode.BadRequest, "Password is wrong!");
            }
        }

        public async Task<bool> RegisterAsync(AdminRegisterDto adminRegister)
        {
            var adminResult = await _unitOfWork.Admins.FirstOrDefaultAsync(x => x.Email == adminRegister.Email);
            if (adminResult is not null)
            {
                throw new StatusCodeException(System.Net.HttpStatusCode.Conflict, "Email already exist");
            }

            var password = PassowrdHasher.Hash(adminRegister.Password);

            var adminUser = (Admin)adminRegister;

            adminUser.PasswordHash = password.PasswordHash;
            adminUser.Salt = password.Salt;

            _unitOfWork.Admins.Add(adminUser);
            var result = await _unitOfWork.SaveChangeAsync();
            return result > 0;
        }
    }
}
