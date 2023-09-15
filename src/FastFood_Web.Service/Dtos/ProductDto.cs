using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Enums;
using FastFood_Web.Service.Common.Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dtos
{
    public class ProductDto
    {
        [Required]
        public string CategoryId { get; set; } = string.Empty;
        [Required, MaxLength(30)]
        public string Name { get; set; } = String.Empty;
        [Required, MaxFileSize(2), AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".webp", })]
        public IFormFile? Image { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public FastFoodVolume FastFoodVolume { get; set; }

        public static implicit operator Product(ProductDto productDto)
        {
            return new Product
            {
                CategoryId = productDto.CategoryId,
                Name = productDto.Name,
                Price = productDto.Price,
                //          FastFoodVolume = productDto.FastFoodVolume,
            };
        }

    }
}
