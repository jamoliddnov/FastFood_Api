namespace FastFood_Web.Service.Dto.OrderDto
{
    public class OrderDetailCreateDto
    {

        public string ProductId { get; set; } = String.Empty;

        public byte Amount { get; set; }
        public double Price { get; set; }
    }
}
