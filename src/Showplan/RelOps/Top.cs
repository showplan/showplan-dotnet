using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("TopType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Top : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] TieColumns { get; set; }

        /// <remarks/>
        public ScalarExpression OffsetExpression { get; set; }

        /// <remarks/>
        public ScalarExpression TopExpression { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool RowCount { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RowCountSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Rows { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RowsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool IsPercent { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool IsPercentSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithTies { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithTiesSpecified { get; set; }
    }
}
