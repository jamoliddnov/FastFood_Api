using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class OrderDetail : Base
    {
        public string OrderId { get; set; } = string.Empty;
        public virtual Order Order { get; set; } = default!;
        public string ProductId { get; set; } = string.Empty;
        public virtual Product Product { get; set; } = default!;
        public byte Amount { get; set; }
        public double Price { get; set; }
    }
}
