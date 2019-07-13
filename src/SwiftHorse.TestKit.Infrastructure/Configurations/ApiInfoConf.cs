using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Configurations
{
    internal class ApiInfoConf : IEntityTypeConfiguration<ApiInfo>
    {
        public void Configure(EntityTypeBuilder<ApiInfo> builder)
        {
            builder.ToTable("Apis");
            builder.HasKey(x => x.Id);
        }
    }
}
