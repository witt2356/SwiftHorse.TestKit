using System;

namespace SwiftHorse.TestKit.Core.Domain
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
    }
}
