using FastFood_Web.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dtos
{
    public class CategoryDto
    {
        [Required, MaxLength(30)]
        public string Name { get; set; } = String.Empty;

        public static implicit operator CategoryFastFood(CategoryDto categoryDto)
        {
            return new CategoryFastFood
            {
                CategoryName = categoryDto.Name,
            };
        }
    }
}
