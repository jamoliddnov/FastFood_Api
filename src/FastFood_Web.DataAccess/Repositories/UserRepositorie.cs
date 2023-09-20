using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FastFood_Web.DataAccess.Repositories
{
    public class UserRepositorie : GenericRepositorie<User>, IUserRepositorie
    {
        public UserRepositorie(AppDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<User>? LastOrDefaultAsync(Expression<Func<User, bool>> expression)
        {
            var result = await _dbSet.OrderByDescending(x => x.Id).LastOrDefaultAsync(expression);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
