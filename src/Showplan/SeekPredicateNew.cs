using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("SeekPredicateNewType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class SeekPredicateNew : SeekPredicateBase
    {
        /// <remarks/>
        [XmlElement("SeekKeys")]
        public SeekPredicate[] SeekKeys { get; set; }
    }
}
