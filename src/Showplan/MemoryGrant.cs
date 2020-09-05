using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("MemoryGrantType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class MemoryGrant
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong SerialRequiredMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong SerialDesiredMemory { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong RequiredMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RequiredMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong DesiredMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DesiredMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong RequestedMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RequestedMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantWaitTime { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GrantWaitTimeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantedMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GrantedMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MaxUsedMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MaxUsedMemorySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong MaxQueryMemory { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MaxQueryMemorySpecified { get; set; }
    }
}
