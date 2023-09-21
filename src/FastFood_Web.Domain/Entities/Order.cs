using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Order : Base
    {
        public string? Description { get; set; } = String.Empty;
        public double TotalSum { get; set; }
        public string LocationId { get; set; } = null!;
        public virtual Location Location { get; set; } = default!;
        public bool OrderCancellation { get; set; } = false;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public ProcessStatus ProcessStatus { get; set; } = ProcessStatus.IsExpected;
        public PaymentType PaymentType { get; set; }
        public string? ReceivingOperatorId { get; set; }
        public ReceivingOperator? ReceivingOperator { get; set; }
        public string CustomerId { get; set; } = String.Empty;
        public virtual Customer Customer { get; set; } = default!;
        public string? DeliverId { get; set; }
        public virtual Deliver? Deliver { get; set; }
    }
}
