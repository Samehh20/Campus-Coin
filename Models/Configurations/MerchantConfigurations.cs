namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    

    public class MerchantConfigurations : IEntityTypeConfiguration<Merchant>
    {
        public void Configure(EntityTypeBuilder<Merchant> builder)
        {
            builder.HasOne(x => x.User)
                 .WithOne(x => x.Merchant)
                 .HasForeignKey<Merchant>(x => x.UserId);

           
        }
    }
}
