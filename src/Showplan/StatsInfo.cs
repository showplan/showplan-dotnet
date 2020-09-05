using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("StatsInfoType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class StatsInfo
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Database { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Schema { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Table { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Statistics { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong ModificationCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double SamplingPercent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public System.DateTime LastUpdate { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LastUpdateSpecified { get; set; }
    }
}
