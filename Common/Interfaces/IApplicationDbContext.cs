// <copyright file="IApplicationDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CampusCoin.Common.Interfaces
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    public interface IApplicationDbContext : IApplicationDbContextBase
    {
         DbSet<User> Users { get; set; }
         DbSet<Client> Clients { get; set; }
         DbSet<Superior> Superiors { get; set; }
         DbSet<Admin> Admins { get; set; }
         DbSet<Merchant> Merchants { get; set; }
         DbSet<Wallet> Wallets { get; set; }
         DbSet<ManagerialBranch> ManagerialBranchs { get; set; }
         DbSet<DepositTransaction> DepositTransactions { get; set; }
         DbSet<TransferTransaction> TransferTransactions { get; set; }
         DbSet<PaymentRequest> PaymentRequests { get; set; }
         DbSet<DepositTransactionType> DepositTransactionTypes { get; set; }

    }
}