using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;
using FastFood_Web.Service.Common.Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.ProductDto
{
    public class CreateProductDto
    {
        [Required]
        public string CategoryId { get; set; } = string.Empty;
        [Required, MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        [Required, MaxFileSize(2), AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".web", })]
        public IFormFile? Image { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public FastFoodVolume FastFoodVolume { get; set; }

        public static implicit operator Product(CreateProductDto productDto)
        {
            return new Product
            {
                CategoryId = productDto.CategoryId,
                Name = productDto.Name,
                Price = productDto.Price,
                FastFoodVolume = productDto.FastFoodVolume,
            };
        }
    }
}
