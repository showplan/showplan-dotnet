using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true,
        Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class DefinedValuesListTypeDefinedValue
    {
        /// <remarks/>
        [XmlElement("ColumnReference", typeof(ColumnReference), Order = 0)]
        [XmlElement("ValueVector", typeof(DefinedValuesListTypeDefinedValueValueVector),
            Order = 0)]
        public object Item { get; set; }

        /// <remarks/>
        [XmlElement("ColumnReference", typeof(ColumnReference), Order = 1)]
        [XmlElement("ScalarOperator", typeof(Scalar), Order = 1)]
        public object[] Items { get; set; }
    }
}
