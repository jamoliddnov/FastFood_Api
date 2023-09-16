using FastFood_Web.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.DistrictDto
{
    public class DistrictCreateDto
    {
        [Required, MaxLength(30)]
        public string Name { get; set; } = String.Empty;

        public static implicit operator District(DistrictCreateDto districtCreateDto)
        {
            return new District
            {
                DistrictName = districtCreateDto.Name,
            };
        }
    }
}
