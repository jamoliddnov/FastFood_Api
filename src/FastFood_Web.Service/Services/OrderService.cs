﻿using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Dto.OrderDto;
using FastFood_Web.Service.Helpers;
using FastFood_Web.Service.Interfaces;
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
                var resultOrder =  await _unitOfWork.Orders.FirstOrDefaultAsync(x => x.Id == id);

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

        public async Task<Order> GetByIdAsync(string id)
        {
            try
            {
                var result = await _unitOfWork.Orders.FirstOrDefaultAsync(x => x.Id == id);

                if (result == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound,"Not found order!");
                }
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
