﻿using Microsoft.AspNetCore.Http;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IFileService
    {
        // [DisallowNull]
        public Task<string> SaveImageAsync(IFormFile image);
    }
}
