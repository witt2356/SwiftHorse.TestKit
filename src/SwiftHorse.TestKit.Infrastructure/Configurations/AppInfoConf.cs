using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Configurations
{
    internal class AppInfoConf : IEntityTypeConfiguration<AppInfo>
    {
        public void Configure(EntityTypeBuilder<AppInfo> builder)
        {
            builder.ToTable("Applications");
            builder.HasKey(x => x.Id);
        }
    }
}
