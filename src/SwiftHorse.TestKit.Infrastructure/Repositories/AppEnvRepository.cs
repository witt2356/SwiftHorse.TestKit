using Abp.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.Models;
using SwiftHorse.TestKit.Infrastructure;
using SwiftHorse.TestKit.Infrastructure.Repositories;
using System;

namespace SwiftHorse.TestKit.Core.IRepositories
{
    internal class AppEnvRepository : RepositoryBase<TestKitDbContext, AppEnv, Guid>, IAppEnvRepository
    {
        public AppEnvRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
