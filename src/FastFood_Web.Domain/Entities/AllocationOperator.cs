using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class AllocationOperator : Base
    {
        public UserRole UserRole { get; set; } = UserRole.AllocationOperator;
        public Guid UserId { get; set; }
        public virtual User User { get; set; } = default!;
    }
}
