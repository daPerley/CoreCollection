﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SportsStore.Models;

namespace SportsStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161211215723_Orders")]
    partial class Orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsStore.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("CartLineID");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductID");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("SportsStore.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<bool>("GiftWrap");

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip");

                    b.HasKey("OrderId");

                    b.ToTable("ORders");
                });

            modelBuilder.Entity("SportsStore.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SportsStore.Models.CartLine", b =>
                {
                    b.HasOne("SportsStore.Models.Order")
                        .WithMany("Lines")
                        .HasForeignKey("OrderId");

                    b.HasOne("SportsStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");
                });
        }
    }
}
