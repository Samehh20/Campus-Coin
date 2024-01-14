namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
  

    public class ManagerialBranchConfigurations : IEntityTypeConfiguration<ManagerialBranch>
    {
        public void Configure(EntityTypeBuilder<ManagerialBranch> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
