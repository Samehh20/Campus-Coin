using CampusCoin.Common.Interfaces;
using CampusCoin.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace CampusCoin.Models
{
    public class ApplicationDbContext : ApplicationDbContextBase, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Superior> Superiors { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<ManagerialBranch> ManagerialBranchs { get; set; }
        public DbSet<DepositTransaction> DepositTransactions { get; set; }
        public DbSet<TransferTransaction> TransferTransactions { get; set; }
        public DbSet<PaymentRequest> PaymentRequests { get; set; }
        public DbSet<DepositTransactionType> DepositTransactionTypes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
         
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
