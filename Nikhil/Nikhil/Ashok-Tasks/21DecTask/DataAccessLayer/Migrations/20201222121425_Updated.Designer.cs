﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20201222121425_Updated")]
    partial class Updated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DataAccessLayer.Customer", b =>
                {
                    b.Property<int>("Customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrdersOrder_no")
                        .HasColumnType("int");

                    b.Property<int>("Salesman_id")
                        .HasColumnType("int");

                    b.HasKey("Customer_id");

                    b.HasIndex("OrdersOrder_no");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DataAccessLayer.Orders", b =>
                {
                    b.Property<int>("Order_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Customer_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Purchase_amt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Salesman_id")
                        .HasColumnType("int");

                    b.HasKey("Order_no");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataAccessLayer.Salesman", b =>
                {
                    b.Property<int>("Salesman_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Commision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Customer_id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrdersOrder_no")
                        .HasColumnType("int");

                    b.HasKey("Salesman_id");

                    b.HasIndex("Customer_id");

                    b.HasIndex("OrdersOrder_no");

                    b.ToTable("Salesman");
                });

            modelBuilder.Entity("DataAccessLayer.Customer", b =>
                {
                    b.HasOne("DataAccessLayer.Orders", "Orders")
                        .WithMany("Customers")
                        .HasForeignKey("OrdersOrder_no");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataAccessLayer.Salesman", b =>
                {
                    b.HasOne("DataAccessLayer.Customer", "Customer")
                        .WithMany("Salesmen")
                        .HasForeignKey("Customer_id");

                    b.HasOne("DataAccessLayer.Orders", "Orders")
                        .WithMany("Salesmen")
                        .HasForeignKey("OrdersOrder_no");

                    b.Navigation("Customer");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataAccessLayer.Customer", b =>
                {
                    b.Navigation("Salesmen");
                });

            modelBuilder.Entity("DataAccessLayer.Orders", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Salesmen");
                });
#pragma warning restore 612, 618
        }
    }
}
