using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Dto.OrderDto;
using FastFood_Web.Service.Helpers;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Services.Common.Utils;
using FastFood_Web.Service.ViewModels;
using System.Net;

#pragma warning disable

namespace FastFood_Web.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderDetailService _orderService;
        private readonly ILocationService _locationService;

        public OrderService(IUnitOfWork unitOfWork, IOrderDetailService orderService, ILocationService locationService)
        {
            _unitOfWork = unitOfWork;
            _orderService = orderService;
            _locationService = locationService;
        }

        public async Task<bool> CreateAsync(OrderCreateDto orderCreateDto)
        {
            try
            {
                Order order = new Order();

                if (orderCreateDto.Description != null)
                {
                    order.Description = orderCreateDto.Description;
                }
                order.PaymentType = orderCreateDto.PaymentType;
                order.CustomerId = orderCreateDto.CustomerId;

                Location location = new Location();
                location.Latitude = orderCreateDto.Latitude;
                location.Longitude = orderCreateDto.Longitude;

                var resultLocationId = await _locationService.CreateAsync(location);

                order.LocationId = resultLocationId;
                order.CreateAt = TimeHelpers.GetCurrentServerTime();

                _unitOfWork.Orders.Add(order);

                var res = await _unitOfWork.SaveChangeAsync();

                var resultSum = await _orderService.CreateAsync(order.Id, orderCreateDto.OrderDetails);
                order.TotalSum = resultSum;

                _unitOfWork.Orders.Update(order, order.Id);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
                var resultOrder = await _unitOfWork.Orders.FirstOrDefaultAsync(x => x.Id == id);

                if (resultOrder == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Not found order!");
                }

                _unitOfWork.Orders.Delete(id);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;

            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<OrderViewModel>>? GetAllAsync(PagenationParams @params, ProcessStatus status)
        {
            try
            {

                var resultOrder = _unitOfWork.Orders.GetAll(status);

                IList<OrderViewModel> result = new List<OrderViewModel>();

                if (resultOrder != null)
                {
                    foreach (var item in resultOrder)
                    {
                        OrderViewModel resultViewModel = new OrderViewModel();
                        resultViewModel.Description = item.Description;
                        resultViewModel.TotalSum = item.TotalSum;

                        result.Add(resultViewModel);
                    }

                    return result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<OrderViewModel> GetByIdAsync(string id)
        {
            try
            {
                var result = await _unitOfWork.Orders.FirstOrDefaultAsync(x => x.Id == id);

                if (result == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Not found order!");
                }

                OrderViewModel orderViewModel = new OrderViewModel()
                {
                    CreateAt = result.CreateAt,
                    UpdateAt = result.UpdateAt,
                    CustomerId = result.CustomerId,
                    OrderCancellation = result.OrderCancellation,
                    DeliverId = result.DeliverId,
                    Description = result.Description,
                    LocationId = result.LocationId,
                    PaymentType = result.PaymentType,
                    ProcessStatus = result.ProcessStatus,
                    ReceivingOperatorId = result.ReceivingOperatorId,
                    TotalSum = result.TotalSum,

                };

                return orderViewModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(string id, OrderUpdateDto orderUpdateDto)
        {
            try
            {
                var resultOrder = await _unitOfWork.Orders.FindByIdAsync(id);

                if (resultOrder != null)
                {
                    if (orderUpdateDto.ProcessStatus != null)
                    {
                        resultOrder.ProcessStatus = orderUpdateDto.ProcessStatus.Value;
                    }
                    if (orderUpdateDto.TotalSum != null)
                    {
                        resultOrder.TotalSum = (double)(orderUpdateDto.TotalSum);
                    }
                    if (orderUpdateDto.Description != null)
                    {
                        resultOrder.Description = orderUpdateDto?.Description;
                    }
                    if (orderUpdateDto.DeliverId != null)
                    {
                        resultOrder.DeliverId = orderUpdateDto.DeliverId;
                    }

                    _unitOfWork.Orders.Update(resultOrder, id);

                    var result = await _unitOfWork.SaveChangeAsync();

                    return result > 0;

                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
