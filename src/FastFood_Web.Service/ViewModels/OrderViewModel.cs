using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Service.ViewModels
{
    public class OrderViewModel
    {
        public string? Description { get; set; } = String.Empty;
        public double TotalSum { get; set; }
        public string? LocationId { get; set; }
        public bool OrderCancellation { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public ProcessStatus ProcessStatus { get; set; }
        public PaymentType PaymentType { get; set; }
        public string? ReceivingOperatorId { get; set; }
        public string? CustomerId { get; set; }
        public string? DeliverId { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
