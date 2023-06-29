﻿using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dtos.AccountDto
{
    public class SendToEmailDto
    {
        [Required, EmailAttribute]
        public string Email { get; set; } = String.Empty;
    }
}
