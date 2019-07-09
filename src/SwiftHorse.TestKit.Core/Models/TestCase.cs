using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SwiftHorse.TestKit.Core.Models
{
    public class TestCase : AggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid ApiId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<TestCaseAssert> Asserts { get; set; }
    }
}
