using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Customer : Base
    {
        public string Email { get; set; } = String.Empty;
        public bool IsDeleteProfile { get; set; } = false;
        public byte Canceled { get; set; } = 0;
        public UserRole UserRole { get; set; } = UserRole.Customer;
        public string UserId { get; set; } = String.Empty;
        public virtual User User { get; set; } = default!;
    }
}
