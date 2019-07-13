using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftHorse.TestKit.Core.IServices.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class InAppInfoSaveDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AppId { get; set; }
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

    /// <summary>
    /// 
    /// </summary>
    public class OutAppInfoSaveDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid AppId { get; set; }
    }
}
