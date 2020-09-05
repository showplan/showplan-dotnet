using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SpoolType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Spool : RelOpBase
    {
        /// <remarks/>
        [XmlElement("SeekPredicate", typeof(SeekPredicate))]
        [XmlElement("SeekPredicateNew", typeof(SeekPredicateNew))]
        public object Item { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Stack { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool StackSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int PrimaryNodeId { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PrimaryNodeIdSpecified { get; set; }
    }
}
