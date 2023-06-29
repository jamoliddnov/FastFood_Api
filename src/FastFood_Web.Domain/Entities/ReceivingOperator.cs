using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class ReceivingOperator : Base
    {
        public UserRole UserRole { get; set; } = UserRole.ReceivingOperator;
        public Guid DistrictFilialId { get; set; }
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
    }
}
