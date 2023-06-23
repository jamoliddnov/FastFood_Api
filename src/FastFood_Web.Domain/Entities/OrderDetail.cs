using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class OrderDetail : Base
    {
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; } = default!;
        public Guid TypeFastFoodId { get; set; }
        public virtual TypeFastFood TypeFastFood { get; set; } = default!;
        public byte Amount { get; set; }
        public double Price { get; set; }
    }
}
