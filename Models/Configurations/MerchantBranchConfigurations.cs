namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
  

    public class MerchantBranchConfigurations : IEntityTypeConfiguration<MerchantBranch>
    {
        public void Configure(EntityTypeBuilder<MerchantBranch> builder)
        {
            builder.HasOne(x => x.Merchant)
                .WithMany(x => x.MerchantBranchs)
                .HasForeignKey(x => x.MerchantId);
        }
    }
}
