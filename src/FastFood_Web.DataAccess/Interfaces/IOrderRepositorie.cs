﻿using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;

namespace FastFood_Web.DataAccess.Interfaces
{
    public interface IOrderRepositorie : IGenericRepositorie<Order>
    {
        public Task<Order?> GetByIdAsync(string id);
    }
}
