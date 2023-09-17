using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IUnitOfWork
    {
        public IAdminRepositorie Admins { get; }
        public IAllocationOperatorRepositore AllocationOperators { get; }
        public ICategoryRepositorie Categorys { get; }
        public ICustomerRepositorie Customers { get; }
        public IDeliverRepositorie Delivers { get; }
        public IDistrictRepositorie Districts { get; }
        public IDistrictFilialRepositorie DistrictFilials { get; }
        public IOrderRepositorie Orders { get; }
        public IOrderDetailRepositorie OrderDetails { get; }
        public IRecevingOperatorRepositorie RecevingOperators { get; }
        public IProductRepositorie Products { get; }
        public IUserRepositorie Users { get; }
        public ILocationRepositories Locations { get; }

        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        public Task<int> SaveChangeAsync();
    }
}
