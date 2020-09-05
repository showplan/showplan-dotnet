using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("CompareType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Compare
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public Scalar[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CompareOp CompareOp { get; set; }
    }
}
