using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dto.OrderDto;

namespace FastFood_Web.Service.Interfaces
{
    public interface IOrderService
    {
        public Task<bool> CreateAsync(OrderCreateDto orderCreateDto);
        public Task<bool> DeleteAsync(string id);
        public Task<Order> GetByIdAsync(string id);
      
    }
}
