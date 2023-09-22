using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Exceptions;
using FastFood_Web.Service.Dto.DistrictFilialDto;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Common;
using Microsoft.EntityFrameworkCore;
using System.Net;

#pragma warning disable

namespace FastFood_Web.Service.Services
{
    public class DistrictFilialService : IDistrictFilialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILocationService _locationService;
        private readonly IFileService _fileService;

        public DistrictFilialService(IUnitOfWork unitOfWork, ILocationService locationService, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _locationService = locationService;
            _fileService = fileService;
        }

        public async Task<bool> CreateAsync(DistrictFilialCreateDto districtFilialCreateDto)
        {
            try
            {
                Location location = new Location();

                location.Latitude = districtFilialCreateDto.Latitude;
                location.Longitude = districtFilialCreateDto.Longitude;

                var resultLocationAdd = await _locationService.CreateAsync(location);
                if (resultLocationAdd != "")
                {
                    var districtFilial = (DistrictFilial)districtFilialCreateDto;
                    districtFilial.LocationId = resultLocationAdd;

                    if (districtFilialCreateDto.Image != null)
                    {
                        districtFilial.ImagePath = await _fileService.SaveImageAsync(districtFilialCreateDto.Image);
                    }

                    _unitOfWork.DistrictFilials.Add(districtFilial);
                }

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
                var districtFilial = await _unitOfWork.DistrictFilials.FindByIdAsync(id);
                if (districtFilial is null)
                {
                    throw new StatusCodeException(System.Net.HttpStatusCode.NotFound, "Filial not found!");
                }
                _unitOfWork.Entry(districtFilial).State = EntityState.Detached;

                _unitOfWork.DistrictFilials.Delete(id);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;

            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<DistrictFilial>> GetAllAsync()
        {
            try
            {
                var result = _unitOfWork.DistrictFilials.GetAll();

                if (result.Count() > 0)
                {
                    return result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(string id, DistrictFilialUpdateDto districtFilialUpdateDto)
        {
            try
            {
                var resultDistrict = await _unitOfWork.DistrictFilials.FindByIdAsync(id);

                if (resultDistrict is null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Filial not found!");
                }

                _unitOfWork.Entry(resultDistrict).State = EntityState.Detached;

                if (districtFilialUpdateDto.Name != null)
                {
                    resultDistrict.DistrictFilialName = districtFilialUpdateDto.Name;
                }

                _unitOfWork.DistrictFilials.Update(resultDistrict, id);

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
