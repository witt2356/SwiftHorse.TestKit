using SwiftHorse.TestKit.Core.Domain;
using System;
using System.Collections.Generic;

namespace SwiftHorse.TestKit.Core.IServices.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class InApiInfoLoadDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ApiInfo> Apis { get; set; }
    }
}
