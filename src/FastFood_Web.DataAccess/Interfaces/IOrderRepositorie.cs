using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.DataAccess.Interfaces
{
    public interface IOrderRepositorie : IGenericRepositorie<Order>
    {
        public IQueryable<Order>? GetAll(ProcessStatus status);
    }
}
