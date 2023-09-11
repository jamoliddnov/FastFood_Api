using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.DataAccess.Repositories
{
    public class UserRepositorie : GenericRepositorie<User>, IUserRepositorie
    {
        public UserRepositorie(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
