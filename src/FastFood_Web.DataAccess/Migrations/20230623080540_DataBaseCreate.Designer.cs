﻿// <auto-generated />
using System;
using FastFood_Web.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FastFood_Web.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230623080540_DataBaseCreate")]
    partial class DataBaseCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FastFood_Web.Domain.Entities.AllocationOperator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("AllocationOperators");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.CategoryFastFood", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CategoryFastFoods");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<byte>("Canceled")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleteProfile")
                        .HasColumnType("boolean");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.Deliver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DistrictFilialId")
                        .HasColumnType("uuid");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DistrictFilialId");

                    b.ToTable("Delivers");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.District", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.DistrictFilial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DistrictFilialName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DistrictId")
                        .HasColumnType("uuid");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("DistrictFilials");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DeliverId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("OrderCancellation")
                        .HasColumnType("boolean");

                    b.Property<int>("PaymentType")
                        .HasColumnType("integer");

                    b.Property<int>("ProcessStatus")
                        .HasColumnType("integer");

                    b.Property<Guid>("ReceivingOperatorId")
                        .HasColumnType("uuid");

                    b.Property<double>("TotalSum")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliverId");

                    b.HasIndex("ReceivingOperatorId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<byte>("Amount")
                        .HasColumnType("smallint");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<Guid>("TypeFastFoodId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("TypeFastFoodId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.ReceivingOperator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DistrictFilialId")
                        .HasColumnType("uuid");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DistrictFilialId");

                    b.ToTable("ReceivingOperators");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.TypeFastFood", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryFastFoodId")
                        .HasColumnType("uuid");

                    b.Property<int>("FastFoodVolume")
                        .HasColumnType("integer");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoryFastFoodId");

                    b.ToTable("TypeFastFoods");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.Deliver", b =>
                {
                    b.HasOne("FastFood_Web.Domain.Entities.DistrictFilial", "DistrictFilial")
                        .WithMany()
                        .HasForeignKey("DistrictFilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DistrictFilial");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.DistrictFilial", b =>
                {
                    b.HasOne("FastFood_Web.Domain.Entities.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.Order", b =>
                {
                    b.HasOne("FastFood_Web.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastFood_Web.Domain.Entities.Deliver", "Deliver")
                        .WithMany()
                        .HasForeignKey("DeliverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastFood_Web.Domain.Entities.ReceivingOperator", "ReceivingOperator")
                        .WithMany()
                        .HasForeignKey("ReceivingOperatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Deliver");

                    b.Navigation("ReceivingOperator");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("FastFood_Web.Domain.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastFood_Web.Domain.Entities.TypeFastFood", "TypeFastFood")
                        .WithMany()
                        .HasForeignKey("TypeFastFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("TypeFastFood");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.ReceivingOperator", b =>
                {
                    b.HasOne("FastFood_Web.Domain.Entities.DistrictFilial", "DistrictFilial")
                        .WithMany()
                        .HasForeignKey("DistrictFilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DistrictFilial");
                });

            modelBuilder.Entity("FastFood_Web.Domain.Entities.TypeFastFood", b =>
                {
                    b.HasOne("FastFood_Web.Domain.Entities.CategoryFastFood", "CategoryFastFood")
                        .WithMany()
                        .HasForeignKey("CategoryFastFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryFastFood");
                });
#pragma warning restore 612, 618
        }
    }
}