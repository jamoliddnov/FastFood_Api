using FastFood_Web.Domain.Enums;
using FastFood_Web.Service.Dto.OrderDto;
using FastFood_Web.Service.Services.Common.Utils;
using FastFood_Web.Service.ViewModels;

namespace FastFood_Web.Service.Interfaces
{
    public interface IOrderService
    {
        public Task<bool> CreateAsync(OrderCreateDto orderCreateDto);
        public Task<bool> DeleteAsync(string id);
        public Task<OrderViewModel> GetByIdAsync(string id);
        public Task<IEnumerable<OrderViewModel>>? GetAllAsync(PagenationParams @params, ProcessStatus processStatus);

        public Task<bool> UpdateAsync(string id, OrderUpdateDto orderUpdateDto);

    }
}
