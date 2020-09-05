using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SpillToTempDbType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class SpillToTempDb
    {
        /// <remarks/>
        [XmlAttribute()]
        public ulong SpillLevel { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SpillLevelSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ulong SpilledThreadCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SpilledThreadCountSpecified { get; set; }
    }
}
