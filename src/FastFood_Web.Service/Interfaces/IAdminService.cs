﻿using FastFood_Web.Service.Dtos.AdminDto;

namespace FastFood_Web.Service.Interfaces
{
    public interface IAdminService
    {
        public Task<bool> RegisterAsync(AdminRegisterDto adminRegister);
        public Task<string> LoginAsync(AdminLoginDto adminLoginDto);
    }
}
