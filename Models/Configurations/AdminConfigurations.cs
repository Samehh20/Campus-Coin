namespace Pnu.Eservices.ScientificResearch.Api.Infrastructure.Persistence.Configurations
{
    using CampusCoin.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    

    public class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasOne(x => x.User)
                .WithOne(x => x.Admin)
                .HasForeignKey<Admin>(x => x.UserId);

            builder.HasOne(x => x.ManagerialBranch)
         .WithMany(x => x.Admins)
         .HasForeignKey(x => x.ManagerialBranchId);
        }
    }
}
