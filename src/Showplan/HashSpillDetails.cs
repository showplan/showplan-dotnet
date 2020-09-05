using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("HashSpillDetailsType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class HashSpillDetails
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong GrantedMemoryKb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GrantedMemoryKbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong UsedMemoryKb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UsedMemoryKbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WritesToTempDb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WritesToTempDbSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ReadsFromTempDb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ReadsFromTempDbSpecified { get; set; }
    }
}
