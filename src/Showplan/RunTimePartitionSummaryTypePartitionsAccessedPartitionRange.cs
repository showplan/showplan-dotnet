﻿using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class RunTimePartitionSummaryTypePartitionsAccessedPartitionRange
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong Start { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong End { get; set; }
    }
}
