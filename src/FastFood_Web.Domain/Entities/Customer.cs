using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Customer : User
    {
        public string Email { get; set; } = String.Empty;
        public bool IsDeleteProfile { get; set; } = false;
        public byte Canceled { get; set; } = 0;
        public UserRole UserRole { get; set; } = UserRole.Customer;
    }
}
