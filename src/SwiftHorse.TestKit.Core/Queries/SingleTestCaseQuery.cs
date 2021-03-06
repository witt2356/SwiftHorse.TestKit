﻿using SwiftHorse.TestKit.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Queries
{
    internal class SingleTestCaseQuery : ITestCaseQuery
    {
        private readonly ITestCaseRepository _repository;

        public SingleTestCaseQuery(ITestCaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TestCaseDto>> Query(Guid id)
        {
            var sql = @"SELECT a.Url,a.HttpMethod,a.ContentType,tc.Data FROM TestCases tc
                INNER JOIN Apis a ON a.Id=tc.ApiId
                WHERE tc.Id=@Id;";
            return await _repository.QueryAsync<TestCaseDto>(sql, new { Id = id });
        }
    }
}
