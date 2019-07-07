using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SwiftHorse.TestKit.Core.Models
{
    /// <summary>
    /// Integration test case
    /// </summary>
    public class IntegrationTest : AggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public ICollection<IntegrationCase> Cases { get; set; }
    }
}
