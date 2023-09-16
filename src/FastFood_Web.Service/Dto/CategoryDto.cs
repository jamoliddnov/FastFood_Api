using FastFood_Web.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto
{
    public class CategoryDto
    {
        [Required, MaxLength(30)]
        public string Name { get; set; } = String.Empty;

        public static implicit operator Category(CategoryDto categoryDto)
        {
            return new Category
            {
                Name = categoryDto.Name,
            };
        }
    }
}
