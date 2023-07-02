using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Interfaces.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FastFood_Web.DataAccess.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _appDbContext;

        public IAdminRepositorie Admins { get; }
        public IAllocationOperatorRepositore AllocationOperators { get; }

        public ICategoryFastFoodRepositorie CategoryFastFoods { get; }

        public ICustomerRepositorie Customers { get; }

        public IDeliverRepositorie Delivers { get; }
        public IDistrictRepositorie Districts { get; }

        public IDistrictFilialRepositorie DistrictFilials { get; }

        public IOrderRepositorie Orders { get; }

        public IOrderDetailRepositorie OrderDetails { get; }

        public IRecevingOperatorRepositorie RecevingOperators { get; }

        public ITypeFastFoodRepositorie TypeFastFoods { get; }

        public IUserRepositorie Users { get; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            Admins = new AdminRepositorie(appDbContext);
            AllocationOperators = new AllocationOperatorRepositorie(appDbContext);
            CategoryFastFoods = new CategoryFastFoodRepositorie(appDbContext);
            Customers = new CustomerRepositorie(appDbContext);
            Delivers = new DeliverRepositorie(appDbContext);
            Districts = new DistrictRepositorie(appDbContext);
            DistrictFilials = new DistrictFilialRepositorie(appDbContext);
            Orders = new OrderRepositorie(appDbContext);
            OrderDetails = new OrderDetailRepositorie(appDbContext);
            RecevingOperators = new RecevingOperatorRepositorie(appDbContext);
            TypeFastFoods = new TypeFastFoodRepositorie(appDbContext);
            Users = new UserRepositorie(appDbContext);
        }

        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            return _appDbContext.Entry(entity);
        }

        public async Task<int> SaveChangeAsync()
        {
            try
            {
                return await _appDbContext.SaveChangesAsync();
            }
            catch
            {
                return 0;
            }
        }
    }
}
