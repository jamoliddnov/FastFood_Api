using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.DistrictFilialDto
{
    public class DistrictFilialCreateDto
    {
        [Required, MaxLength(30)]
        public string Name { get; set; } = String.Empty;
        [MaxFileSize(2), AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".web" })]
        public IFormFile? FormFile { get; set; }
        [Required, Number]
        public string Latitude { get; set; } = String.Empty;
        [Required, Number]
        public string Longitude { get; set; } = String.Empty;
        [Required]
        public string DistrictId { get; set; } = String.Empty;

        public static implicit operator DistrictFilial(DistrictFilialCreateDto districtFilialCreateDto)
        {
            return new DistrictFilial
            {
                DistrictFilialName = districtFilialCreateDto.Name,
                DistrictId = districtFilialCreateDto.DistrictId
            };
        }
    }
}

