using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal abstract class RepositoryBase<TDbContext, TEntity, TPrimaryKey> : EfCoreRepositoryBase<TDbContext, TEntity, TPrimaryKey>
        where TDbContext : DbContext
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public RepositoryBase(IDbContextProvider<TDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<T> FirstOrDefaultAsync<T>(string sql, object param)
        {
            return await Connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction: Transaction);
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param)
        {
            return await Connection.QueryAsync<T>(sql, param, transaction: Transaction);
        }
    }
}
