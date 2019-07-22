using SwiftHorse.TestKit.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core
{
    internal class IntegrationTestCaseQuery : ITestCaseQuery
    {
        private readonly IIntegrationTestRepository _repository;

        public IntegrationTestCaseQuery(IIntegrationTestRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TestCaseDto>> Query(Guid id)
        {
            var sql = @"SELECT a.Url,a.HttpMethod,a.ContentType,tc.Data,ic.Order FROM IntegrationCases ic
                INNER JOIN IntegrationTests it ON it.Id=ic.TestId AND it.Id=@Id
                INNER JOIN TestCases tc ON tc.Id=ic.CaseId
                INNER JOIN Apis a ON a.Id=tc.ApiId;";
            return await _repository.QueryAsync<TestCaseDto>(sql, new { Id = id });
        }
    }
}
