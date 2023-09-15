using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.AccountDto
{
    public class EmailVerifyDto
    {
        [Required, Email]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Code { get; set; }
    }
}
