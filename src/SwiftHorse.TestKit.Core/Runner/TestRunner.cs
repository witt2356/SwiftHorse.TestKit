using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Core.Queries;
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

        public async Task RunSingle(Guid envId, Guid caseId)
        {
            var query = ActivatorUtilities.CreateInstance<SingleTestCaseQuery>(_serviceProvider);
            await Run(envId, query, caseId);
        }

        public async Task RunIntegration(Guid envId, Guid integrationId)
        {
            var query = ActivatorUtilities.CreateInstance<IntegrationTestCaseQuery>(_serviceProvider);
            await Run(envId, query, integrationId);
        }

        private async Task Run(Guid envId, ITestCaseQuery query, Guid id)
        {
            var env = await _appEnvRepository.FirstOrDefaultAsync(x => x.Id == envId);

            var testCases = await query.Query(id);
            await _executor.Execute(env.Host, testCases);
        }
    }
}
