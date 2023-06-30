using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class User : Base
    {
        public string Email { get; set; } = String.Empty;
        public string FullName { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;
        public UserRole UserRole { get; set; } = UserRole.Customer;
        public DateTime CreateAt { get; set; }
    }
}
