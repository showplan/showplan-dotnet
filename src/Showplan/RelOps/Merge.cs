using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("MergeType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Merge : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] InnerSideJoinColumns { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] OuterSideJoinColumns { get; set; }

        /// <remarks/>
        public ScalarExpression Residual { get; set; }

        /// <remarks/>
        public ScalarExpression PassThru { get; set; }

        /// <remarks/>
        public StarJoinInfo StarJoinInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ManyToMany { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ManyToManySpecified { get; set; }
    }
}
