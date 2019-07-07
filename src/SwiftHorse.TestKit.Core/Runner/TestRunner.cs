﻿using SwiftHorse.TestKit.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Runner
{
    public abstract class TestRunner
    {
        public async Task Run(Guid id)
        {
            var cases = await GetCases(id);

            var executor = ServiceResolver.CreateInstance<HttpExecutor>();
            foreach (var tc in cases)
            {
                var response = await executor.SendAsync("http://localhost", tc);
            }
        }

        public abstract Task<IEnumerable<TestCaseDto>> GetCases(Guid id);
    }

    public class TestCaseDto
    {
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public string ContentType { get; set; }
        public string Data { get; set; }
        public int Order { get; set; }
    }
}
