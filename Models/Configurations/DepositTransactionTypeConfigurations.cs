namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
  

    public class DepositTransactionTypeConfigurations : IEntityTypeConfiguration<DepositTransactionType>
    {
        public void Configure(EntityTypeBuilder<DepositTransactionType> builder)
        {
            builder.HasKey(x => x.Id);
              
        }
    }
}
