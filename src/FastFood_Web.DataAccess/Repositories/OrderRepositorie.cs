using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;


namespace FastFood_Web.DataAccess.Repositories
{
    public class OrderRepositorie : GenericRepositorie<Order>, IOrderRepositorie
    {
        public OrderRepositorie(AppDbContext dbContext) : base(dbContext)
        {

        }

        public virtual IQueryable<Order>? GetAll(ProcessStatus status)
        {
            try
            {
              //  ProcessStatus[] allStatus = (ProcessStatus[])Enum.GetValues(typeof(ProcessStatus));
                var res = _dbSet.Where(x => x.ProcessStatus == status);
                return res;
            }
            catch
            {
                return null;
            }
        }


    }
}
