using FastFood_Web.Service.Dto.OrderDto;

namespace FastFood_Web.Service.Interfaces
{
    public interface IOrderService
    {
        public Task<bool> CreateAsync(OrderCreateDto orderCreateDto);
    }
}
