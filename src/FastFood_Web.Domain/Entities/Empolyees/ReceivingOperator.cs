using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Entities.Districts;

namespace FastFood_Web.Domain.Entities.Empolyees
{
    public class ReceivingOperator : Base
    {
        public string DistrictFilialId { get; set; } = string.Empty;
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
    }
}
