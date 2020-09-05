using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class RunTimePartitionSummaryTypePartitionsAccessed
    {
        /// <remarks/>
        [XmlElement("PartitionRange")]
        public RunTimePartitionSummaryTypePartitionsAccessedPartitionRange[] PartitionRange { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong PartitionCount { get; set; }
    }
}
