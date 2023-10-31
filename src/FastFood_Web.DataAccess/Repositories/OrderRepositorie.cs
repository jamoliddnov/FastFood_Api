using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.DataAccess.Repositories
{
    public class OrderRepositorie : GenericRepositorie<Order>, IOrderRepositorie
    {
        public OrderRepositorie(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Order>? GetAll(ProcessStatus status)
        {
            try
            {
                var result = _dbSet.Where(x => x.ProcessStatus == status).AsNoTracking();

                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
