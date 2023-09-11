using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Domain.Entities
{
    public class Order : Base
    {
        public string Description { get; set; } = string.Empty;
        public double TotalSum { get; set; }
        public string Location { get; set; } = string.Empty;
        public bool OrderCancellation { get; set; } = false;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public ProcessStatus ProcessStatus { get; set; } = ProcessStatus.IsBeingPrepared;
        public PaymentType PaymentType { get; set; }
        public string ReceivingOperatorId { get; set; } = string.Empty;
        public ReceivingOperator ReceivingOperator { get; set; } = default!;
        public string CustomerId { get; set; } = string.Empty;
        public virtual Customer Customer { get; set; } = default!;
        public string DeliverId { get; set; } = string.Empty;
        public virtual Deliver Deliver { get; set; } = default!;
    }
}
