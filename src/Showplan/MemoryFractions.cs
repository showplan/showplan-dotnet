using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("MemoryFractionsType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class MemoryFractions
    {
        /// <remarks/>
        [XmlAttribute()]
        public double Input { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Output { get; set; }
    }
}
