using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.DataAccess.Repositories
{
    public class TypeFastFoodRepositorie : GenericRepositorie<TypeFastFood>, ITypeFastFoodRepositorie
    {
        public TypeFastFoodRepositorie(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
