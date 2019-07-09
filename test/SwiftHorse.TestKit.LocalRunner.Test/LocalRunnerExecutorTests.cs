using SwiftHorse.TestKit.Core;
using SwiftHorse.TestKit.Core.IRepositories;
using SwiftHorse.TestKit.Core.Runner;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SwiftHorse.TestKit.LocalRunner.Test
{
    public class LocalRunnerExecutorTests
    {
        private readonly TestRunner _runner;

        public LocalRunnerExecutorTests()
        {

        }

        [Fact]
        public async Task SendAsync_UrlParam()
        {
            //_runner.TestCase = new TestCaseDto { Url = "/api/test/{0}", HttpMethod = "Get", Data = "1" };
            //await _runner.run(Guid.Empty);
        }

        [Fact]
        public async Task SendAsync_Url()
        {
            //var data = "a=1&b=2";
            //_runner.TestCase = new TestCaseDto { Url = "/api/test", HttpMethod = "Get", ContentType = ContentTypes.Url, Data = data };
            //await _runner.Run(Guid.Empty);
        }

        [Fact]
        public async Task SendAsync_Json()
        {
            //var data = JsonConvert.SerializeObject(new { A = "1" });
            //_runner.TestCase = new TestCaseDto { Url = "/api/test", HttpMethod = "Post", ContentType = ContentTypes.Json, Data = data };
            //await _runner.Run(Guid.Empty);
        }
    }

    //public class FakeTestRunner : ITestCaseQuery<ITestCaseRepository>
    //{
    //    public TestCaseDto TestCase { get; set; }

    //    public override async Task<IEnumerable<TestCaseDto>> GetCases(Guid id)
    //    {
    //        return new[] { TestCase };
    //    }
    //}
}
