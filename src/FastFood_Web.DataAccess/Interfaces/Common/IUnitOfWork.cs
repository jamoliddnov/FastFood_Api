﻿namespace FastFood_Web.DataAccess.Interfaces.Common
{
    public interface IUnitOfWork
    {
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
        public Task<int> SaveChangeAsync();
    }
}