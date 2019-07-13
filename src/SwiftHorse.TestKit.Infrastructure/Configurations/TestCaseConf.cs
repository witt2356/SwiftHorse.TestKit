using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Configurations
{
    internal class TestCaseConf : IEntityTypeConfiguration<TestCase>
    {
        public void Configure(EntityTypeBuilder<TestCase> builder)
        {
            builder.ToTable("TestCases");
            builder.HasKey(x => x.Id);
        }
    }
}
