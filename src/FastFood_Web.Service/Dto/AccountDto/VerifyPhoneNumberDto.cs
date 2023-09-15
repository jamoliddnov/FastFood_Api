using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dtos.AccountDto
{
    public class VerifyPhoneNumberDto
    {
        [Required, PhoneNumber]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public int Code { get; set; }
    }
}
