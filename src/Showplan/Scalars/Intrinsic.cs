using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("IntrinsicType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Intrinsic
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public Scalar[] ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string FunctionName { get; set; }
    }
}
