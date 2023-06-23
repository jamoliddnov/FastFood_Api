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


        }

        public Task<int> SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
