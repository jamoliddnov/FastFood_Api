using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;

namespace FastFood_Web.DataAccess.Repositories
{
    public class DistrictRepositorie : GenericRepositorie<District>, IDistrictRepositorie
    {
        public DistrictRepositorie(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
