using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwiftHorse.TestKit.Core.Models;
using System;

namespace SwiftHorse.TestKit.Infrastructure.Configurations
{
    internal class AppConf : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications");
            builder.HasKey(x => x.Id);
        }
    }
}
