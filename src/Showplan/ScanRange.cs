using System.Xml.Serialization;

namespace Showplan
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ScanRangeType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class ScanRange
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] RangeColumns { get; set; }

        /// <remarks/>
        [XmlArrayItem("ScalarOperator", IsNullable = false)]
        public Scalar[] RangeExpressions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public CompareOp ScanType { get; set; }
    }
}
