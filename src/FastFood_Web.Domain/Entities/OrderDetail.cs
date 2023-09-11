using FastFood_Web.Domain.Common;

namespace FastFood_Web.Domain.Entities
{
    public class OrderDetail : Base
    {
        public string OrderId { get; set; } = string.Empty;
        public virtual Order Order { get; set; } = default!;
        public string TypeFastFoodId { get; set; } = string.Empty;
        public virtual TypeFastFood TypeFastFood { get; set; } = default!;
        public byte Amount { get; set; }
        public double Price { get; set; }
    }
}
