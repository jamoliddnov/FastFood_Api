using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.AccountDto
{
    public class AccountRegisterDto
    {
        [Required, MinLength(1), MaxLength(40)]
        public string FullName { get; set; } = String.Empty;
        [Required, PhoneNumberAttribute]
        public string PhoneNumber { get; set; } = String.Empty;

        public static implicit operator User(AccountRegisterDto accountRegister)
        {
            return new User()
            {
                FullName = accountRegister.FullName,
                PhoneNumber = accountRegister.PhoneNumber,
            };
        }
    }
}




