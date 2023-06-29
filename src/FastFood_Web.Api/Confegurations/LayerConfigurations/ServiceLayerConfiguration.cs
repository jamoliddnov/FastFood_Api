using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Service.Common.Security;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.Services;
using FastFood_Web.Service.Services.Common;

namespace FastFood_Web.Api.Confegurations.LayerConfigurations
{
    public static class ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceDescriptors.AddScoped<IAccountSevrice, AccountService>();
            serviceDescriptors.AddScoped<IEmailService, EmailService>();
            serviceDescriptors.AddScoped<IAuthManager, AuthManager>();
            
            serviceDescriptors.AddAutoMapper(typeof(MappingConfiguration));
        }
    }
}
