using System;
using System.Collections.Generic;

namespace SwiftHorse.TestKit.Core.Domain
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
        //public ICollection<TestCaseAssertion> Assertions { get; set; }
    }
}
