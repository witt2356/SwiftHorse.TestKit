using SwiftHorse.TestKit.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Runner
{
    public class TestIntegrationRunner : TestRunner
    {
        private readonly IIntegrationTestRepository _repository;

        public TestIntegrationRunner(IIntegrationTestRepository repository)
        {
            _repository = repository;
        }

        public override async Task<IEnumerable<TestCaseDto>> GetCases(Guid id)
        {
            var sql = @"SELECT a.Url,a.HttpMethod,a.ContentType,tc.Data,ic.Order FROM IntegrationCases ic
                INNER JOIN IntegrationTests it ON it.Id=ic.TestId AND it.Id=@Id
                INNER JOIN TestCases tc ON tc.Id=ic.CaseId
                INNER JOIN Apis a ON a.Id=tc.ApiId;";
            return await _repository.QueryAsync<TestCaseDto>(sql, new { Id = id });
        }
    }
}
