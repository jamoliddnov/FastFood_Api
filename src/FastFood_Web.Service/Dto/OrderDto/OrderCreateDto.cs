using FastFood_Web.Domain.Enums;
using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.OrderDto
{
    public class OrderCreateDto
    {
        [MaxLength(200)]
        public string? Description { get; set; } = String.Empty;
        [Required, Number]
        public string Latitude { get; set; } = String.Empty;
        [Required, Number]
        public string Longitude { get; set; } = String.Empty;
        [Required]
        public PaymentType PaymentType { get; set; }
        [Required]
        public string CustomerId { get; set; } = String.Empty;

        [Required]
        public List<OrderDetailCreateDto>? OrderDetails { get; set; }


    }
}
