using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class AllocationOperator : User
    {
        public UserRole UserRole { get; set; } = UserRole.AllocationOperator;
    }
}
