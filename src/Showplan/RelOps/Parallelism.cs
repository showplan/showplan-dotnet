using System.Xml.Serialization;

namespace Showplan.RelOps
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType("ParallelismType", Namespace = "http://schemas.microsoft.com/sqlserver/2004/07/showplan")]
    public class Parallelism : RelOpBase
    {
        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] PartitionColumns { get; set; }

        /// <remarks/>
        [XmlArrayItem("OrderByColumn", IsNullable = false)]
        public OrderByTypeOrderByColumn[] OrderBy { get; set; }

        /// <remarks/>
        [XmlArrayItem("ColumnReference", IsNullable = false)]
        public ColumnReference[] HashKeys { get; set; }

        /// <remarks/>
        public SingleColumnReference ProbeColumn { get; set; }

        /// <remarks/>
        public ScalarExpression Predicate { get; set; }

        /// <remarks/>
        public ParallelismTypeActivation Activation { get; set; }

        /// <remarks/>
        public ParallelismTypeBrickRouting BrickRouting { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public Partition PartitioningType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool PartitioningTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool Remoting { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool RemotingSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool LocalParallelism { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool LocalParallelismSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool InRow { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool InRowSpecified { get; set; }
    }
}
