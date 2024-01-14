namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
  

    public class SuperiorConfigurations : IEntityTypeConfiguration<Superior>
    {
        public void Configure(EntityTypeBuilder<Superior> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
