using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Service.Common.Security;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Accounts;
using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.Services;
using FastFood_Web.Service.Services.Accounts;
using FastFood_Web.Service.Services.Common;

namespace FastFood_Web.Api.Confegurations.LayerConfigurations
{
    public static class ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddHttpContextAccessor();
            serviceDescriptors.AddScoped<IUnitOfWork, UnitOfWork>();


            serviceDescriptors.AddScoped<IVerifyEmailService, VerifyEmailService>();
            serviceDescriptors.AddScoped<IAdminService, AdminService>();
            serviceDescriptors.AddScoped<IAccountSevrice, AccountService>();
            serviceDescriptors.AddScoped<IEmailService, EmailService>();
            serviceDescriptors.AddScoped<IFileService, FileService>();
            serviceDescriptors.AddScoped<ICategoryService, CategoryService>();
            serviceDescriptors.AddScoped<IProductService, ProductService>();
            serviceDescriptors.AddScoped<IDistrictService, DistrictService>();
            serviceDescriptors.AddScoped<IPaginatonService, PaginationService>();
            serviceDescriptors.AddScoped<IDistrictFilialService, DistrictFilialService>();
            serviceDescriptors.AddScoped<IAuthManager, AuthManager>();
            serviceDescriptors.AddScoped<IIdentityService, IdentityService>();
            serviceDescriptors.AddAutoMapper(typeof(MappingConfiguration));
        }
    }
}
