using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;
using FastFood_Web.Service.Common.Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace FastFood_Web.Service.Dto.ProductDto
{
    public class UpdateProductDto
    {
        public string? CategoryId { get; set; } = string.Empty;
        [MaxLength(30)]
        public string? Name { get; set; } = string.Empty;
        [MaxFileSize(2), AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".web", })]
        public IFormFile? Image { get; set; }

        public float? Price { get; set; }
        public FastFoodVolume? FastFoodVolume { get; set; }

    }
}
