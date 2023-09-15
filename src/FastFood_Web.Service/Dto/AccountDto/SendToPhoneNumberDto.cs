﻿using FastFood_Web.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dtos.AccountDto
{
    public class SendToPhoneNumberDto
    {
        [Required, PhoneNumber]
        public string PhoneNumber { get; set; } = String.Empty;
    }
}