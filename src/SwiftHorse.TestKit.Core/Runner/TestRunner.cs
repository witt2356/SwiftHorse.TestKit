using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.IRepositories;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Runner
{
    public class TestRunner
    {
        private readonly IRunnerExecutor _executor;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAppEnvRepository _appEnvRepository;

        public TestRunner(IRunnerExecutor executor,
            IServiceProvider serviceProvider,
            IAppEnvRepository appEnvRepository)
        {
            _executor = executor;
            _serviceProvider = serviceProvider;
            _appEnvRepository = appEnvRepository;
        }

        public async Task RunSingle(Guid envId, Guid id)
        {
            var query = _serviceProvider.GetService<ITestCaseQuery<ITestCaseRepository>>();
            await Run(envId, query, id);
        }

        public async Task RunIntegration(Guid envId, Guid id)
        {
            var query = _serviceProvider.GetService<ITestCaseQuery<IIntegrationTestRepository>>();
            await Run(envId, query, id);
        }

        private async Task Run(Guid envId, ITestCaseQuery query, Guid id)
        {
            var env = await _appEnvRepository.FirstOrDefaultAsync(x => x.Id == envId);

            var testCases = await query.Query(id);
            foreach (var testCase in testCases)
            {
                await _executor.Execute(env.Host, testCase);
            }
        }
    }
}
