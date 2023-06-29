namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IUnitOfWork
    {
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
        public IUserRepositorie UserRepositories { get; }
        public Task<int> SaveChangeAsync();
    }
}
