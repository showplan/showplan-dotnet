using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("MissingIndexGroupType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class MissingIndexGroup
    {
        /// <remarks/>
        [XmlElement("MissingIndex")]
        public MissingIndex[] MissingIndex { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Impact { get; set; }
    }
}
