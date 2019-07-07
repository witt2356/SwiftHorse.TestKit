using Abp.Domain.Values;
using System;
using System.Collections.Generic;

namespace SwiftHorse.TestKit.Core.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class IntegrationCase : ValueObject
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid CaseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Order { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return CaseId;
            yield return Order;
        }
    }
}
