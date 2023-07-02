using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities.Empolyees;

namespace FastFood_Web.DataAccess.Repositories
{
    public class RecevingOperatorRepositorie : GenericRepositorie<ReceivingOperator>, IRecevingOperatorRepositorie
    {
        public RecevingOperatorRepositorie(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
