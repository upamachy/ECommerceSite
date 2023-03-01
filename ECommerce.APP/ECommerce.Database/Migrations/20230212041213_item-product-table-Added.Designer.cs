﻿// <auto-generated />
using System;
using ECommerce.Database.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFcoreExample.Migrations
{
    [DbContext(typeof(SMEDBContext))]
    [Migration("20230212041213_item-product-table-Added")]
    partial class itemproducttableAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFcoreExample.Models.EntityModels.Catagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Catagories");
                });

            modelBuilder.Entity("EFcoreExample.Models.EntityModels.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatagoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CatagoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EFcoreExample.Models.EntityModels.Item", b =>
                {
                    b.HasOne("EFcoreExample.Models.EntityModels.Catagory", null)
                        .WithMany("Items")
                        .HasForeignKey("CatagoryId");
                });

            modelBuilder.Entity("EFcoreExample.Models.EntityModels.Catagory", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
