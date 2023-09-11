using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class Customer : Base
    {
        public bool IsDeleteProfile { get; set; } = false;
        public byte Canceled { get; set; } = 0;
        public string UserId { get; set; } = string.Empty;
        public virtual User User { get; set; } = default!;
    }
}
