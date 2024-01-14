namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
  

    public class TransferTransactionConfigurations : IEntityTypeConfiguration<TransferTransaction>
    {
        public void Configure(EntityTypeBuilder<TransferTransaction> builder)
        {
            builder.HasOne(x => x.ToWallet)
                .WithMany(x => x.TransferTransactions)
                .HasForeignKey(x => x.ToWalletId);
        }
    }
}
