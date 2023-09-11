using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IPaginatonService
    {
        public Task<IList<T>> ToPageAsync<T>(IQueryable<T> items, int pageNumber, int pageSize);
    }
}
