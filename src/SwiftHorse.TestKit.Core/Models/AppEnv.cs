using Abp.Domain.Entities;
using System;

namespace SwiftHorse.TestKit.Core.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AppEnv : AggregateRoot<Guid>
    {
        /// <summary>
        /// Application Id
        /// </summary>
        public Guid AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Host { get; set; }
    }
}
