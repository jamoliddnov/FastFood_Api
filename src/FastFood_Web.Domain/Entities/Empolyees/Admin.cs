using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities.Empolyees
{
    public class Admin : Base
    {
        public string FullName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;
        public UserRole UserRole { get; set; } = UserRole.Admin;
    }
}
