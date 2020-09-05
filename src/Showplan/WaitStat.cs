using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("WaitStatType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class WaitStat
    {
        /// <remarks/>
        [XmlAttribute()]
        public string WaitType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WaitTimeMs { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong WaitCount { get; set; }
    }
}
