﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payment_System_API;

#nullable disable

namespace Payment_System_API.Migrations
{
    [DbContext(typeof(PaymentContext))]
    partial class PaymentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("Payment_System_API.DataAccessLayer.Customer_Details", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalIdNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Payment_System_API.DataAccessLayer.Merchant_Details", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("AverageTransactionVolume")
                        .HasColumnType("TEXT");

                    b.Property<int>("BusinessId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfEstablishment")
                        .HasColumnType("TEXT");

                    b.Property<string>("MerchantNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MerchantNumber")
                        .IsUnique();

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("Payment_System_API.DataAccessLayer.TransactionHistories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Customer_DetailsId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Customer_DetailsId");

                    b.ToTable("TransactionHistories");
                });

            modelBuilder.Entity("Payment_System_API.DataAccessLayer.TransactionHistories", b =>
                {
                    b.HasOne("Payment_System_API.DataAccessLayer.Customer_Details", null)
                        .WithMany("TransactionHistory")
                        .HasForeignKey("Customer_DetailsId");
                });

            modelBuilder.Entity("Payment_System_API.DataAccessLayer.Customer_Details", b =>
                {
                    b.Navigation("TransactionHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
