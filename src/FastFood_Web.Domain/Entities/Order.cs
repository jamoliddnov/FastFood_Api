using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Order : Base
    {
        public string Description { get; set; } = String.Empty;
        public double TotalSum { get; set; }
        public string Location { get; set; } = String.Empty;
        public bool OrderCancellation { get; set; } = false;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public ProcessStatus ProcessStatus { get; set; } = ProcessStatus.IsBeingPrepared;
        public PaymentType PaymentType { get; set; }
        public Guid ReceivingOperatorId { get; set; }
        public ReceivingOperator ReceivingOperator { get; set; } = default!;
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = default!;
        public Guid DeliverId { get; set; }
        public virtual Deliver Deliver { get; set; } = default!;
    }
}
