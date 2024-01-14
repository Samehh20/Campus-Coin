namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    

    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(x => x.Client)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.ClientId);
            
            builder.HasOne(x => x.Merchant)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.MerchantId);

            builder.HasOne(x => x.Admin)
         .WithOne(x => x.User)
         .HasForeignKey<User>(x => x.AdminId);

            builder.HasOne(x => x.Wallet)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.WalletId);
        }
    }
}
