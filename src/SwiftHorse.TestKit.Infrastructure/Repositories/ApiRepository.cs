using Abp.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.IRepositories;
using SwiftHorse.TestKit.Core.Models;
using System;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class ApiRepository : RepositoryBase<TestKitDbContext, Api, Guid>, IApiRepository
    {
        public ApiRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
