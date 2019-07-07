using Abp.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.IRepositories;
using SwiftHorse.TestKit.Core.Models;
using System;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class IntegrationTestRepository : RepositoryBase<TestKitDbContext, IntegrationTest, Guid>, IIntegrationTestRepository
    {
        public IntegrationTestRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
