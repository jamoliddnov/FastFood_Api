using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Entities.Users;

namespace FastFood_Web.Domain.Entities.Empolyees
{
    public class AllocationOperator : Base
    {
        public string UserId { get; set; } = string.Empty;
        public virtual User User { get; set; } = default!;
    }
}
