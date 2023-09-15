using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Common.Attributes
{
    public class AllowedFilesAttribute : ValidationAttribute
    {
        private readonly string[] _extension;

        public AllowedFilesAttribute(string[] extension)
        {
            _extension = extension;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file is not null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (_extension.Contains(extension.ToLower()))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("This file extension is not supperted!");
                }
            }
            return ValidationResult.Success;
        }
    }
}
