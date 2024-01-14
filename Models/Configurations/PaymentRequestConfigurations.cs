namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
  

    public class PaymentRequestConfigurations : IEntityTypeConfiguration<PaymentRequest>
    {
        public void Configure(EntityTypeBuilder<PaymentRequest> builder)
        {
            //builder.HasOne(x => x.FromWallet)
            //    .WithMany(x => x.PaymentRequests)
            //    .HasForeignKey(x => x.FromWalletId);

            builder.HasOne(x => x.ToWallet)
                .WithMany(x => x.PaymentRequests)
                .HasForeignKey(x => x.ToWalletId);
        }
    }
}
