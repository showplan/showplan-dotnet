using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ThreadStatType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ThreadStat
    {
        /// <remarks/>
        [XmlElement("ThreadReservation")]
        public ThreadReservation[] ThreadReservation { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Branches { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int UsedThreads { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool UsedThreadsSpecified { get; set; }
    }
}
