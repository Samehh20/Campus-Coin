namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
  

    public class DepositTransactionConfigurations : IEntityTypeConfiguration<DepositTransaction>
    {
        public void Configure(EntityTypeBuilder<DepositTransaction> builder)
        {
            builder.HasOne(x => x.Wallet)
                .WithMany(x => x.DepositTransactions)
                .HasForeignKey(x => x.WalletId);
        }
    }
}
