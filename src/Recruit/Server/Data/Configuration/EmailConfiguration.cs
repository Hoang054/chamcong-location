using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recruit.Server.Models;
using Recruit.Server.Models.ModelViews;

namespace Recruit.Server.Data.Configuration
{
    public class EmailConfiguration : IEntityTypeConfiguration<EmailItem>
    {
        public void Configure(EntityTypeBuilder<EmailItem> builder)
        {
            builder.ToTable("Emails");
        }
    }
}
