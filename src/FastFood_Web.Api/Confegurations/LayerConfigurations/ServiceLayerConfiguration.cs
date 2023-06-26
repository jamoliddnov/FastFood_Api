using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Services;

namespace FastFood_Web.Api.Confegurations.LayerConfigurations
{
    public static class ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<IAccountSevrice, AccountService>();
        }
    }
}
