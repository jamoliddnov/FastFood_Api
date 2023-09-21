using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dto.OrderDto;
using FastFood_Web.Service.Interfaces;

namespace FastFood_Web.Service.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<double> CreateAsync(string orderId, List<OrderDetailCreateDto> orderDetails)
        {
            try
            {


                double sum = 0;
                foreach (var item in orderDetails)
                {
                    OrderDetail dto = new OrderDetail();
                    dto.OrderId = orderId;
                    dto.ProductId = item.ProductId;
                    dto.Amount = item.Amount;
                    dto.Price = item.Price;
                    sum += item.Price * item.Amount;

                    _unitOfWork.OrderDetails.Add(dto);
                }



                return sum;
            }
            catch
            {
                return 0;
            }

        }
    }
}
