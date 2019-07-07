using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.IRepositories
{
    public interface ITestKitRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        Task<T> FirstOrDefaultAsync<T>(string sql, object param);

        Task<IEnumerable<T>> QueryAsync<T>(string sql, object param);
    }
}
