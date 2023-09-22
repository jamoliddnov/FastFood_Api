using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.DataAccess.Repositories
{
    public class OrderRepositorie : GenericRepositorie<Order>, IOrderRepositorie
    {
        public OrderRepositorie(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Order?> GetByIdAsync(string id)
        {
            try
            {
                var result = _dbSet.Include(x => x.Id);

                if (result != null)
                {
                   
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
