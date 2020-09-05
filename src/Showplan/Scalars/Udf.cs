using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("UdfType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Udf
    {
        /// <remarks/>
        [XmlElement("ScalarOperator")]
        public Scalar[] ScalarOperator { get; set; }

        /// <remarks/>
        public ClrFunction ClrFunction { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string FunctionName { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsClrFunction { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsClrFunctionSpecified { get; set; }
    }
}
