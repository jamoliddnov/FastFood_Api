using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities.Districts;

namespace FastFood_Web.DataAccess.Repositories
{
    public class DistrictFilialRepositorie : GenericRepositorie<DistrictFilial>, IDistrictFilialRepositorie
    {
        public DistrictFilialRepositorie(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
