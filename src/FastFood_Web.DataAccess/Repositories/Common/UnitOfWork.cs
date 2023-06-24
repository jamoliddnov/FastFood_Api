using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Interfaces.Common;

namespace FastFood_Web.DataAccess.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _appDbContext;

        public IAllocationOperatorRepositore AllocationOperator { get; }

        public ICategoryFastFoodRepositorie CategoryFastFood { get; }

        public ICustomerRepositorie Customer { get; }

        public IDeliverRepositorie Deliver { get; }
        public IDistrictRepositorie District { get; }

        public IDistrictFilialRepositorie DistrictFilial { get; }

        public IOrderRepositorie Order { get; }

        public IOrderDetailRepositorie OrderDetail { get; }

        public IRecevingOperatorRepositorie RecevingOperator { get; }

        public ITypeFastFoodRepositorie TypeFastFood { get; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            AllocationOperator = new AllocationOperatorRepositorie(appDbContext);
            CategoryFastFood = new CategoryFastFoodRepositorie(appDbContext);
            Customer = new CustomerRepositorie(appDbContext);
            Deliver = new DeliverRepositorie(appDbContext);
            District = new DistrictRepositorie(appDbContext);
            DistrictFilial = new DistrictFilialRepositorie(appDbContext);
            Order = new OrderRepositorie(appDbContext);
            OrderDetail = new OrderDetailRepositorie(appDbContext);
            RecevingOperator = new RecevingOperatorRepositorie(appDbContext);
            TypeFastFood = new TypeFastFoodRepositorie(appDbContext);
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
