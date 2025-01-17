﻿// <auto-generated />
using System;
using CraftIQ2.infastrcure.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CraftIQ2.infastrcure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CraftI_2.Core.Entinty.BaseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("BaseEntities");

                    b.HasDiscriminator().HasValue("BaseEntity");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Category", b =>
                {
                    b.HasBaseType("CraftI_2.Core.Entinty.BaseEntity");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("_CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Inventroy", b =>
                {
                    b.HasBaseType("CraftI_2.Core.Entinty.BaseEntity");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Reorderlevel")
                        .HasColumnType("int");

                    b.Property<Guid>("_InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("BaseEntities", t =>
                        {
                            t.Property("Name")
                                .HasColumnName("Inventroy_Name");
                        });

                    b.HasDiscriminator().HasValue("Inventroy");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Order", b =>
                {
                    b.HasBaseType("CraftI_2.Core.Entinty.BaseEntity");

                    b.Property<DateTimeOffset>("ExpectedDeliveryDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("ReceivedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<Guid>("_OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasDiscriminator().HasValue("Order");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.OrderDeatils", b =>
                {
                    b.HasBaseType("CraftI_2.Core.Entinty.BaseEntity");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("_OrderDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("BaseEntities", t =>
                        {
                            t.Property("Quantity")
                                .HasColumnName("OrderDeatils_Quantity");
                        });

                    b.HasDiscriminator().HasValue("OrderDeatils");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Product", b =>
                {
                    b.HasBaseType("CraftI_2.Core.Entinty.BaseEntity");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProductionCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProfitPerUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TaxCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TransActionsId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.Property<float>("Width")
                        .HasColumnType("real");

                    b.Property<Guid>("_ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TransActionsId");

                    b.ToTable("BaseEntities", t =>
                        {
                            t.Property("Description")
                                .HasColumnName("Product_Description");

                            t.Property("Name")
                                .HasColumnName("Product_Name");
                        });

                    b.HasDiscriminator().HasValue("Product");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.TransActions", b =>
                {
                    b.HasBaseType("CraftI_2.Core.Entinty.BaseEntity");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("TransactionDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.Property<Guid>("_TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("BaseEntities", t =>
                        {
                            t.Property("Quantity")
                                .HasColumnName("TransActions_Quantity");
                        });

                    b.HasDiscriminator().HasValue("TransActions");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.OrderDeatils", b =>
                {
                    b.HasOne("CraftI_2.Core.Entinty.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CraftI_2.Core.Entinty.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Product", b =>
                {
                    b.HasOne("CraftI_2.Core.Entinty.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CraftI_2.Core.Entinty.TransActions", null)
                        .WithMany("Products")
                        .HasForeignKey("TransActionsId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("CraftI_2.Core.Entinty.TransActions", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
