﻿// <auto-generated />
using System;
using CampusCoin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CampusCoin.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240111223902_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CampusCoin.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerialBranchId")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ManagerialBranchId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CampusCoin.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SuperiorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClientTypeId");

                    b.HasIndex("SuperiorId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CampusCoin.Models.ClientType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientType");
                });

            modelBuilder.Entity("CampusCoin.Models.DepositTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepositTransactionTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerialBranchId")
                        .HasColumnType("int");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DepositTransactionTypeId");

                    b.HasIndex("ManagerialBranchId");

                    b.HasIndex("WalletId");

                    b.ToTable("DepositTransactions");
                });

            modelBuilder.Entity("CampusCoin.Models.DepositTransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DepositTransactionTypes");
                });

            modelBuilder.Entity("CampusCoin.Models.ManagerialBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ManagerialBranchs");
                });

            modelBuilder.Entity("CampusCoin.Models.Merchant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommercialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("CampusCoin.Models.MerchantBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MerchantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MerchantId");

                    b.ToTable("MerchantBranch");
                });

            modelBuilder.Entity("CampusCoin.Models.PaymentRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FromWalletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("ToWalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ToWalletId");

                    b.ToTable("PaymentRequests");
                });

            modelBuilder.Entity("CampusCoin.Models.Superior", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Superiors");
                });

            modelBuilder.Entity("CampusCoin.Models.TransferTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FromWalletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ToWalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ToWalletId");

                    b.ToTable("TransferTransactions");
                });

            modelBuilder.Entity("CampusCoin.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MerchantId")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AdminId")
                        .IsUnique()
                        .HasFilter("[AdminId] IS NOT NULL");

                    b.HasIndex("ClientId")
                        .IsUnique()
                        .HasFilter("[ClientId] IS NOT NULL");

                    b.HasIndex("MerchantId")
                        .IsUnique()
                        .HasFilter("[MerchantId] IS NOT NULL");

                    b.HasIndex("WalletId")
                        .IsUnique()
                        .HasFilter("[WalletId] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CampusCoin.Models.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Ballance")
                        .HasColumnType("float");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("CampusCoin.Models.Admin", b =>
                {
                    b.HasOne("CampusCoin.Models.ManagerialBranch", "ManagerialBranch")
                        .WithMany("Admins")
                        .HasForeignKey("ManagerialBranchId");

                    b.Navigation("ManagerialBranch");
                });

            modelBuilder.Entity("CampusCoin.Models.Client", b =>
                {
                    b.HasOne("CampusCoin.Models.ClientType", "ClientType")
                        .WithMany()
                        .HasForeignKey("ClientTypeId");

                    b.HasOne("CampusCoin.Models.Superior", null)
                        .WithMany("Clients")
                        .HasForeignKey("SuperiorId");

                    b.Navigation("ClientType");
                });

            modelBuilder.Entity("CampusCoin.Models.DepositTransaction", b =>
                {
                    b.HasOne("CampusCoin.Models.DepositTransactionType", "DepositTransactionType")
                        .WithMany()
                        .HasForeignKey("DepositTransactionTypeId");

                    b.HasOne("CampusCoin.Models.ManagerialBranch", "ManagerialBranch")
                        .WithMany()
                        .HasForeignKey("ManagerialBranchId");

                    b.HasOne("CampusCoin.Models.Wallet", "Wallet")
                        .WithMany("DepositTransactions")
                        .HasForeignKey("WalletId");

                    b.Navigation("DepositTransactionType");

                    b.Navigation("ManagerialBranch");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("CampusCoin.Models.MerchantBranch", b =>
                {
                    b.HasOne("CampusCoin.Models.Merchant", "Merchant")
                        .WithMany("MerchantBranchs")
                        .HasForeignKey("MerchantId");

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("CampusCoin.Models.PaymentRequest", b =>
                {
                    b.HasOne("CampusCoin.Models.Wallet", "ToWallet")
                        .WithMany("PaymentRequests")
                        .HasForeignKey("ToWalletId");

                    b.Navigation("ToWallet");
                });

            modelBuilder.Entity("CampusCoin.Models.TransferTransaction", b =>
                {
                    b.HasOne("CampusCoin.Models.Wallet", "ToWallet")
                        .WithMany("TransferTransactions")
                        .HasForeignKey("ToWalletId");

                    b.Navigation("ToWallet");
                });

            modelBuilder.Entity("CampusCoin.Models.User", b =>
                {
                    b.HasOne("CampusCoin.Models.Admin", "Admin")
                        .WithOne("User")
                        .HasForeignKey("CampusCoin.Models.User", "AdminId");

                    b.HasOne("CampusCoin.Models.Client", "Client")
                        .WithOne("User")
                        .HasForeignKey("CampusCoin.Models.User", "ClientId");

                    b.HasOne("CampusCoin.Models.Merchant", "Merchant")
                        .WithOne("User")
                        .HasForeignKey("CampusCoin.Models.User", "MerchantId");

                    b.HasOne("CampusCoin.Models.Wallet", "Wallet")
                        .WithOne("User")
                        .HasForeignKey("CampusCoin.Models.User", "WalletId");

                    b.Navigation("Admin");

                    b.Navigation("Client");

                    b.Navigation("Merchant");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("CampusCoin.Models.Admin", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("CampusCoin.Models.Client", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("CampusCoin.Models.ManagerialBranch", b =>
                {
                    b.Navigation("Admins");
                });

            modelBuilder.Entity("CampusCoin.Models.Merchant", b =>
                {
                    b.Navigation("MerchantBranchs");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CampusCoin.Models.Superior", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("CampusCoin.Models.Wallet", b =>
                {
                    b.Navigation("DepositTransactions");

                    b.Navigation("PaymentRequests");

                    b.Navigation("TransferTransactions");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}