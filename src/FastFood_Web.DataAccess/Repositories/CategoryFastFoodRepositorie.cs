﻿using FastFood_Web.DataAccess.DbContexts;
using FastFood_Web.DataAccess.Interfaces;
using FastFood_Web.DataAccess.Repositories.Common;
using FastFood_Web.Domain.Entities.Products;

namespace FastFood_Web.DataAccess.Repositories
{
    public class CategoryFastFoodRepositorie : GenericRepositorie<CategoryFastFood>, ICategoryFastFoodRepositorie
    {
        public CategoryFastFoodRepositorie(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }
    }
}
