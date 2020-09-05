using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class MemoryGrantWarningInfo
    {
        /// <remarks/>
        [XmlAttribute()]
        public MemoryGrantWarning GrantWarningKind { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong RequestedMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantedMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MaxUsedMemory { get; set; }
    }
}
