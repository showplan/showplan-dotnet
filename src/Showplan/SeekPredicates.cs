using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SeekPredicatesType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class SeekPredicates
    {
        /// <remarks/>
        [XmlElement("SeekPredicate", typeof(SeekPredicate))]
        [XmlElement("SeekPredicateNew", typeof(SeekPredicateNew))]
        [XmlElement("SeekPredicatePart", typeof(SeekPredicatePart))]
        public SeekPredicateBase[] Items { get; set; }
    }
}
