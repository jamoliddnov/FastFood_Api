using FastFood_Web.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.Api.Confegurations.LayerConfigurations
{
    public static class DataAccessConfiguration
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DatabaseConnection");
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
        }
    }
}
