using System;

namespace SwiftHorse.TestKit.Core.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class AppInfo : AggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Descr { get; set; }
    }
}
