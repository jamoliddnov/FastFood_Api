using FastFood_Web.Service.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood_Web.Service.Dtos.AccountDto
{
    public class PasswordUpdateDto
    {
        [Required,PasswordAttribute]
        public string Password { get; set; } = String.Empty;    
    }
}
