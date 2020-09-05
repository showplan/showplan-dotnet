using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class AssignType
    {
        /// <remarks/>
        [XmlElement("ColumnReference", typeof(ColumnReference), Order = 0)]
        [XmlElement("ScalarOperator", typeof(Scalar), Order = 0)]
        public object Item { get; set; }

        /// <remarks/>
        [XmlElement(Order = 1)]
        public Scalar ScalarOperator { get; set; }
    }
}
