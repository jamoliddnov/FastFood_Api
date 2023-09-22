using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Dto.DistrictDto;
using FastFood_Web.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net;

#pragma warning disable

namespace FastFood_Web.Service.Services
{
    public class DistrictService : IDistrictService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DistrictService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(DistrictCreateDto districtCreateDto)
        {
            try
            {
                var district = (District)districtCreateDto;
                _unitOfWork.Districts.Add(district);

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
                _unitOfWork.Districts.Delete(id);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<District>> GetAllAsync()
        {
            try
            {
                var district = _unitOfWork.Districts.GetAll();

                return district;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(string id, DistrictUpdateDto districtUpdateDto)
        {
            try
            {
                var district = await _unitOfWork.Districts.FindByIdAsync(id);

                _unitOfWork.Entry(district).State = EntityState.Detached;

                if (district == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "District not found!");
                }

                if (districtUpdateDto.Name != null)
                {
                    district.DistrictName = districtUpdateDto.Name;
                }

                _unitOfWork.Districts.Update(district, id);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
