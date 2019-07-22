using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftHorse.TestKit.Core.IServices.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class InTestCaseSaveDto
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
    public class OutTestCaseSaveDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid CaseId { get; set; }
    }
}
