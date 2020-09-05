using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("AggregateType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Aggregate
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public Scalar[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string AggType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Distinct { get; set; }
    }
}
