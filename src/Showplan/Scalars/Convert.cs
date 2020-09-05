using System.Xml.Serialization;

namespace Showplan.Scalars
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ConvertType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Convert
    {
        /// <remarks/>
        public ScalarExpression Style { get; set; }

        /// <remarks/>
        public Scalar ScalarOperator { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string DataType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Length { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LengthSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Precision { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PrecisionSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Scale { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ScaleSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("Style")]
        public int Style1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Implicit { get; set; }
    }
}
