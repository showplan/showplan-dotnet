using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ColumnReferenceType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ColumnReference
    {
        /// <remarks/>
        public Scalar ScalarOperator { get; set; }

        /// <remarks/>
        public InternalInfo InternalInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Server { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Database { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Schema { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Table { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Alias { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Column { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ComputedColumn { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ComputedColumnSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterDataType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterCompiledValue { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ParameterRuntimeValue { get; set; }
    }
}
