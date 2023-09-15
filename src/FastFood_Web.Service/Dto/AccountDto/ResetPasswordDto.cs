using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.AccountDto
{
    public class ResetPasswordDto
    {
        [Required(ErrorMessage = "Email is required!"), EmailAttribute]
        public string Email { get; set; } = String.Empty;
        [Required]
        public int Code { get; set; }
        [Required, PasswordAttribute]
        public string Password { get; set; } = String.Empty;
    }
}
