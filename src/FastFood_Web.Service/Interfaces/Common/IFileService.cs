using Microsoft.AspNetCore.Http;
using System.Diagnostics.CodeAnalysis;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IFileService
    {
        public Task<string> SaveImageAsync([DisallowNull] IFormFile image);
    }
}
