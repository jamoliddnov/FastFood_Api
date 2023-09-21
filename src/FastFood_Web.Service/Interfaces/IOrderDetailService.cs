using FastFood_Web.Service.Dto.OrderDto;

namespace FastFood_Web.Service.Interfaces
{
    public interface IOrderDetailService
    {
        public Task<double> CreateAsync(string orderId, List<OrderDetailCreateDto> orderDetails);
    }
}
