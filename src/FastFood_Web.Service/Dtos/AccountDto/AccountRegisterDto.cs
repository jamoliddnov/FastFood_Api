using FastFood_Web.Domain.Entities.Users;
using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dtos.AccountDto
{
    public class AccountRegisterDto
    {
        [Required, MinLength(8), MaxLength(40)]
        public string FullName { get; set; } = String.Empty;
        [Required, PhoneNumberAttribute]
        public string PhoneNumber { get; set; } = String.Empty;
        [Required, Email]
        public string Email { get; set; } = String.Empty;
        [Required, PasswordAttribute]
        public string Password { get; set; } = String.Empty;

        public static implicit operator User(AccountRegisterDto accountRegister)
        {
            return new User()
            {
                Email = accountRegister.Email,
                FullName = accountRegister.FullName,
                PhoneNumber = accountRegister.PhoneNumber,
                PasswordHash = accountRegister.Password
            };
        }
    }
}




