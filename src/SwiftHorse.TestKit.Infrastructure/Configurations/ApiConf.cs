using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwiftHorse.TestKit.Core.Models;

namespace SwiftHorse.TestKit.Infrastructure.Configurations
{
    internal class ApiConf : IEntityTypeConfiguration<Api>
    {
        public void Configure(EntityTypeBuilder<Api> builder)
        {
            builder.ToTable("Apis");
            builder.HasKey(x => x.Id);
        }
    }
}
