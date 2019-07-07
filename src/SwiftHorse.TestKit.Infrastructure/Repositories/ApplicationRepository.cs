using Abp.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.IRepositories;
using SwiftHorse.TestKit.Core.Models;
using System;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class ApplicationRepository : RepositoryBase<TestKitDbContext, Application, Guid>, IApplicationRepository
    {
        public ApplicationRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
