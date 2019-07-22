using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Services
{
    internal class TestCaseService : ITestCaseService
    {
        private readonly ITestCaseRepository _testCaseRepository;

        public TestCaseService(ITestCaseRepository testCaseRepository)
        {
            _testCaseRepository = testCaseRepository;
        }

        public async Task<Guid> Save(InTestCaseSaveDto input)
        {
            throw new NotImplementedException();
        }
    }
}
