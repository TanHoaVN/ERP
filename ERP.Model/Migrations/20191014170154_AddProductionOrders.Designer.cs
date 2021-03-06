﻿// <auto-generated />
using System;
using ERP.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ERP.Model.Migrations
{
    [DbContext(typeof(ERPContext))]
    [Migration("20191014170154_AddProductionOrders")]
    partial class AddProductionOrders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ERP.Model.Models.Customers", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken();

                    b.Property<string>("address");

                    b.Property<string>("code");

                    b.Property<DateTime>("createDate");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<string>("note");

                    b.Property<string>("phone");

                    b.Property<string>("representative");

                    b.Property<string>("representativeEmail");

                    b.Property<string>("representativePhone");

                    b.Property<string>("taxCode");

                    b.Property<DateTime>("updateDate");

                    b.HasKey("Oid");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("ERP.Model.Models.Employees", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken();

                    b.Property<string>("code");

                    b.Property<DateTime>("createDate");

                    b.Property<string>("name");

                    b.Property<DateTime>("updateDate");

                    b.HasKey("Oid");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("ERP.Model.Models.ProductionOrder", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken();

                    b.Property<string>("code");

                    b.Property<DateTime>("createDate");

                    b.Property<Guid?>("customerOid");

                    b.Property<DateTime?>("deadline");

                    b.Property<DateTime?>("finishDate");

                    b.Property<bool>("isLate");

                    b.Property<string>("name");

                    b.Property<string>("note");

                    b.Property<Guid>("productionStatusOid");

                    b.Property<DateTime?>("startDate");

                    b.Property<Guid>("supervisorOid");

                    b.Property<DateTime>("updateDate");

                    b.Property<string>("version")
                        .HasMaxLength(5);

                    b.HasKey("Oid");

                    b.HasIndex("customerOid");

                    b.HasIndex("productionStatusOid");

                    b.HasIndex("supervisorOid");

                    b.ToTable("productionOrders");
                });

            modelBuilder.Entity("ERP.Model.Models.ProductionOrderStatus", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken();

                    b.Property<string>("code")
                        .HasMaxLength(3);

                    b.Property<DateTime>("createDate");

                    b.Property<string>("name");

                    b.Property<string>("note");

                    b.Property<DateTime>("updateDate");

                    b.HasKey("Oid");

                    b.ToTable("productionOrdersStatus");
                });

            modelBuilder.Entity("ERP.Model.Models.Roles", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken();

                    b.Property<Guid?>("UsersOid");

                    b.Property<DateTime>("createDate");

                    b.Property<bool>("isActive");

                    b.Property<string>("name");

                    b.Property<DateTime>("updateDate");

                    b.HasKey("Oid");

                    b.HasIndex("UsersOid");

                    b.ToTable("role");
                });

            modelBuilder.Entity("ERP.Model.Models.Users", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("createDate");

                    b.Property<bool>("isActive");

                    b.Property<string>("storedPassword");

                    b.Property<DateTime>("updateDate");

                    b.Property<string>("username");

                    b.HasKey("Oid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ERP.Model.Models.ProductionOrder", b =>
                {
                    b.HasOne("ERP.Model.Models.Customers", "customer")
                        .WithMany("productionOrders")
                        .HasForeignKey("customerOid");

                    b.HasOne("ERP.Model.Models.ProductionOrderStatus", "status")
                        .WithMany("productionOrders")
                        .HasForeignKey("productionStatusOid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ERP.Model.Models.Employees", "supervisor")
                        .WithMany("productionOrderSupervisor")
                        .HasForeignKey("supervisorOid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ERP.Model.Models.Roles", b =>
                {
                    b.HasOne("ERP.Model.Models.Users")
                        .WithMany("roles")
                        .HasForeignKey("UsersOid");
                });
#pragma warning restore 612, 618
        }
    }
}
