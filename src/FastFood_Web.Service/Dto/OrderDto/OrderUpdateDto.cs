using FastFood_Web.Domain.Enums;

namespace FastFood_Web.Service.Dto.OrderDto
{
    public class OrderUpdateDto
    {
        public string? Description { get; set; } = String.Empty;
        public double? TotalSum { get; set; }
        public ProcessStatus? ProcessStatus { get; set; }
        public string? DeliverId { get; set; }
    }
}





