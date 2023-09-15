using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;

namespace FastFood_Web.DataAccess.Repositories
{
    public class CategoryRepositorie : GenericRepositorie<Category>, ICategoryRepositorie
    {
        public CategoryRepositorie(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }
    }
}
