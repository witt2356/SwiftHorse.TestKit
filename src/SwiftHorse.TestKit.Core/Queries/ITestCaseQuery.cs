using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core
{
    internal interface ITestCaseQuery
    {
        Task<IEnumerable<TestCaseDto>> Query(Guid id);
    }

    internal interface ITestCaseQuery<TRepository> : ITestCaseQuery where TRepository : IRepository
    {
    }
}
