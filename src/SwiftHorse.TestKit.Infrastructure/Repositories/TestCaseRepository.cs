using Abp.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.IRepositories;
using SwiftHorse.TestKit.Core.Models;
using System;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class TestCaseRepository : RepositoryBase<TestKitDbContext, TestCase, Guid>, ITestCaseRepository
    {
        public TestCaseRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
