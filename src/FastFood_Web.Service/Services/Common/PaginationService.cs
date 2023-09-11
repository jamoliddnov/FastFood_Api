using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.Services.Common.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FastFood_Web.Service.Services.Common
{
    public class PaginationService : IPaginatonService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PaginationService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IList<T>> ToPageAsync<T>(IQueryable<T> items, int pageNumber, int pageSize)
        {
            try
            {
                int totalItems = await items.CountAsync();
                PagenationMetaData pagenationMetaData = new PagenationMetaData()
                { 
                    CurrentPage = pageNumber,
                    PageSize = pageSize,
                    TotalItems = totalItems,
                    TotalPages = (int)Math.Ceiling((double)totalItems / (double) pageSize),
                    HasPrevious = pageNumber > 0
                };
                pagenationMetaData.HasNext = pagenationMetaData.CurrentPage < pagenationMetaData.TotalPages;
                string json = JsonConvert.SerializeObject(pagenationMetaData);
                _httpContextAccessor.HttpContext!.Response.Headers.Add("X-Pagination", json);
                return await items.Skip(pageNumber * pageSize - pageSize).Take(pageSize).ToListAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}
