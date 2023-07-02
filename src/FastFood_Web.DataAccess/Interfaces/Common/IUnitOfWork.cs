using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IUnitOfWork
    {
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

        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        public Task<int> SaveChangeAsync();
    }
}
