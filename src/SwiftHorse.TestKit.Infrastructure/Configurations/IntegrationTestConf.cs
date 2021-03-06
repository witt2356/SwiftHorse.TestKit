﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Configurations
{
    internal class IntegrationTestConf : IEntityTypeConfiguration<IntegrationTest>
    {
        public void Configure(EntityTypeBuilder<IntegrationTest> builder)
        {
            builder.ToTable("IntegrationTests");
            builder.HasKey(x => x.Id);
        }
    }
}
