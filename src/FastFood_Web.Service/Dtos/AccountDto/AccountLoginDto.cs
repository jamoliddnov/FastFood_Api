using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dtos.AccountDto
{
    public class AccountLoginDto
    {
        [Required, EmailAttribute]
        public string Email { get; set; } = String.Empty;
        [Required, PasswordAttribute]
        public string Password { get; set; } = String.Empty;
    }
}
