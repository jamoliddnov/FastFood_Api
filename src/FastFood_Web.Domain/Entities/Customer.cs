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
        public string FullName { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;
        public DateTime CreateAt { get; set; }
    }
}
