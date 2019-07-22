using System;

namespace SwiftHorse.TestKit.Core.IServices.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class InAppEnvSaveDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? EnvId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Host { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class OutAppEnvSaveDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid EnvId { get; set; }
    }
}
