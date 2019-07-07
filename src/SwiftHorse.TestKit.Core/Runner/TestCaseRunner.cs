using SwiftHorse.TestKit.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Runner
{
    public class TestCaseRunner : TestRunner
    {
        private readonly ITestCaseRepository _repository;

        public TestCaseRunner(ITestCaseRepository repository)
        {
            _repository = repository;
        }

        public override async Task<IEnumerable<TestCaseDto>> GetCases(Guid id)
        {
            var sql = @"SELECT a.Url,a.HttpMethod,a.ContentType,tc.Data FROM TestCases tc
                INNER JOIN Apis a ON a.Id=tc.ApiId
                WHERE tc.Id=@Id;";
            var testCase = await _repository.FirstOrDefaultAsync<TestCaseDto>(sql, new { Id = id });
            return new[] { testCase };
        }
    }
}
