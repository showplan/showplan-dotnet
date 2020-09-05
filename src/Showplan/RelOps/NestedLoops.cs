using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("NestedLoopsType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class NestedLoops : RelOpBase
    {
        /// <remarks/>
        public ScalarExpression Predicate { get; set; }

        /// <remarks/>
        public ScalarExpression PassThru { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] OuterReferences { get; set; }

        /// <remarks/>
        public SingleColumnReference PartitionId { get; set; }

        /// <remarks/>
        public SingleColumnReference ProbeColumn { get; set; }

        /// <remarks/>
        public StarJoinInfo StarJoinInfo { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Optimized { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithOrderedPrefetch { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithOrderedPrefetchSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool WithUnorderedPrefetch { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool WithUnorderedPrefetchSpecified { get; set; }
    }
}
