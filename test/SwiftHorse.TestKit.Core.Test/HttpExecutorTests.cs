using Newtonsoft.Json;
using SwiftHorse.TestKit.Core.Models;
using SwiftHorse.TestKit.Core.Runner;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace SwiftHorse.TestKit.Core.Test
{
    public class HttpExecutorTests : TestBase
    {
        private readonly FakeTestRunner _runner = new FakeTestRunner();

        [Fact]
        public async Task SendAsync_UrlParam()
        {
            _runner.TestCase = new TestCaseDto { Url = "/api/test/{0}", HttpMethod = "Get", Data = "1" };
            await _runner.Run(Guid.Empty);
        }

        [Fact]
        public async Task SendAsync_Url()
        {
            var data = "a=1&b=2";
            _runner.TestCase = new TestCaseDto { Url = "/api/test", HttpMethod = "Get", ContentType = ContentTypes.Url, Data = data };
            await _runner.Run(Guid.Empty);
        }

        [Fact]
        public async Task SendAsync_Json()
        {
            var data = JsonConvert.SerializeObject(new { A = "1" });
            _runner.TestCase = new TestCaseDto { Url = "/api/test", HttpMethod = "Post", ContentType = ContentTypes.Json, Data = data };
            await _runner.Run(Guid.Empty);
        }
    }

    public class FakeTestRunner : TestRunner
    {
        public TestCaseDto TestCase { get; set; }

        public override async Task<IEnumerable<TestCaseDto>> GetCases(Guid id)
        {
            return new[] { TestCase };
        }
    }
}
