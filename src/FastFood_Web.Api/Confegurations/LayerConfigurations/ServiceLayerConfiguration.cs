using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Service.Common.Security;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Accounts;
using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.Services;
using FastFood_Web.Service.Services.Accounts;
using FastFood_Web.Service.Services.Common;
using Microsoft.Extensions.Caching.Memory;

namespace FastFood_Web.Api.Confegurations.LayerConfigurations
{
    public static class ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddHttpContextAccessor();
            serviceDescriptors.AddScoped<IUnitOfWork, UnitOfWork>();

            serviceDescriptors.AddScoped<IVerifyPhoneNumberService, VerifyPhoneNumberService>();
            serviceDescriptors.AddScoped<IVerifyEmailService, VerifyEmailService>();
            serviceDescriptors.AddScoped<IAdminService, AdminService>();
            serviceDescriptors.AddScoped<IAccountSevrice, AccountService>();
            serviceDescriptors.AddScoped<IEmailService, EmailService>();
            serviceDescriptors.AddScoped<ICategoryService, CategoryService>();
            serviceDescriptors.AddScoped<IPaginatonService, PaginationService>();
            serviceDescriptors.AddScoped<IAuthManager, AuthManager>();
            serviceDescriptors.AddScoped<IIdentityService, IdentityService>();
            serviceDescriptors.AddScoped<IMemoryCache, MemoryCache>();
            serviceDescriptors.AddAutoMapper(typeof(MappingConfiguration));
        }
    }
}
