﻿using FastFood_Web.Domain.Entities.Customers;
using FastFood_Web.Domain.Entities.Districts;
using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Domain.Entities.Orders;
using FastFood_Web.Domain.Entities.Products;
using FastFood_Web.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace FastFood_Web.DataAccess.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Admin> Admins { get; set; } = default!;
        public virtual DbSet<AllocationOperator> AllocationOperators { get; set; } = default!;
        public virtual DbSet<CategoryFastFood> CategoryFastFoods { get; set; } = default!;
        public virtual DbSet<Customer> Customers { get; set; } = default!;
        public virtual DbSet<Deliver> Delivers { get; set; } = default!;
        public virtual DbSet<District> Districts { get; set; } = default!;
        public virtual DbSet<DistrictFilial> DistrictFilials { get; set; } = default!;
        public virtual DbSet<Order> Orders { get; set; } = default!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = default!;
        public virtual DbSet<ReceivingOperator> ReceivingOperators { get; set; } = default!;
        public virtual DbSet<TypeFastFood> TypeFastFoods { get; set; } = default!;
        public virtual DbSet<User> Users { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
