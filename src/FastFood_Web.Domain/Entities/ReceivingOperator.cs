using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class ReceivingOperator : Base
    {
        public string DistrictFilialId { get; set; } = String.Empty;
        public virtual DistrictFilial DistrictFilial { get; set; } = default!;
    }
}
